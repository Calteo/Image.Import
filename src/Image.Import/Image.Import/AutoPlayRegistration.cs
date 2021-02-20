using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;

namespace Image.Import
{
    /// <summary>
    /// Registers the auto play handler in the registry
    /// </summary>
    static class AutoPlayRegistration
    {
        public static bool IsRegistered(RegistryKey root)
        {
            var path = Process.GetCurrentProcess().MainModule.FileName;

            using (var autoplayKey = GetAutoplayKey(root))
            {
                using (var handlersKey = autoplayKey.OpenSubKey("Handlers"))
                {
                    using (var handlerKey = handlersKey.OpenSubKey(HandlerKey))
                    {
                        if (handlerKey == null) return false;
                        var initCmd = handlerKey.GetValue("InitCmdLine")?.ToString();
                        if (path != initCmd?.Trim('"')) return false;
                    }
                }
            }
            return true;
        }

        public static void Register(RegistryKey root)
        {
            var path = Process.GetCurrentProcess().MainModule.FileName;

            using (var autoplayKey = GetAutoplayKey(root, true))
            {
                using (var handlersKey = autoplayKey.OpenSubKey("Handlers", true))
                {
                    using (var handlerKey = handlersKey.CreateSubKey(HandlerKey, true))
                    {
                        handlerKey.SetValue("Action", "Import Images", RegistryValueKind.ExpandString);
                        handlerKey.SetValue("Provider", "Calteo Image Import", RegistryValueKind.ExpandString);
                        handlerKey.SetValue("DefaultIcon", $"\"{path}\",0", RegistryValueKind.ExpandString);
                        handlerKey.SetValue("InitCmdLine", $"\"{path}\"", RegistryValueKind.String);
                        handlerKey.SetValue("InvokeProgID", ProgId, RegistryValueKind.ExpandString);
                        handlerKey.SetValue("InvokeVerb", "open", RegistryValueKind.String);
                    }
                }

                using (var showPicturesKey = autoplayKey.OpenSubKey(@"EventHandlers\ShowPicturesOnArrival", true))
                {
                    showPicturesKey.SetValue(HandlerKey, "");
                }
            }


            using (var classesKey = GetClassesKey(root, true))
            {
                using (var progIdKey = classesKey.CreateSubKey(ProgId, true))
                {
                    using (var commandKey = progIdKey.CreateSubKey(@"shell\open\command", true))
                    {
                        commandKey.SetValue("", $"\"{path}\" %1");
                    }
                }
            }
        }

        internal static void Unregister(RegistryKey root)
        {
            using (var autoplayKey = GetAutoplayKey(root, true))
            {
                using (var handlersKey = autoplayKey.OpenSubKey("Handler", true))
                {
                    handlersKey.DeleteSubKeyTree(HandlerKey);
                }
                using (var showPicturesKey = autoplayKey.OpenSubKey(@"EventHandlers\ShowPicturesOnArrival", true))
                {
                    showPicturesKey.DeleteValue(HandlerKey);
                }
            }
            using (var classesKey = GetClassesKey(root, true))
            {
                classesKey.DeleteSubKeyTree(ProgId);
            }
        }

        private const string HandlerKey = "CalteoImageImportHandler";
        private const string ProgId = "Calteo.Image.Import";

        private static RegistryKey GetKey(RegistryKey root, string name, bool writable)
        {
            var key = root.OpenSubKey(name, writable);

            if (key == null)
                throw new NullReferenceException(@$"Registry key '{root.Name}\{name}' failed to open.");

            return key;
        }

        private static RegistryKey GetAutoplayKey(RegistryKey root, bool writable = false)
        {
            return GetKey(root, @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\AutoplayHandlers", writable);
        }

        private static RegistryKey GetClassesKey(RegistryKey root, bool writable = false)
        {
            return GetKey(root, @"SOFTWARE\Classes", writable);
        }
    }
}
