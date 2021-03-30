using System;
using System.Threading;
using System.Windows.Forms;

namespace Image.Import
{
    class BackgroundWorker<TI, TO>
    {
        public BackgroundWorker(Form form, Func<TI> initHandler, Func<TI, TO> workHandler, Action<TO, bool, Exception> completeHandler)
        {
            Form = form;
            Init = initHandler;
            Work = workHandler;
            Complete = completeHandler;
        }

        public Form Form { get; }
        private Func<TI> Init { get; }
        private Func<TI, TO> Work { get; }
        private Action<TO, bool, Exception> Complete { get; }
        private Exception Exception { get; set; }
        public bool CancellationPending { get; private set; }
        private TO Output { get; set; }

        private Thread Worker { get; set; }
        public bool Running => Worker != null;

        public void Start()
        {
            if (Worker != null)
            {
                CancellationPending = true;
                Worker.Join();
            }

            var parameter = Init();

            Worker = new Thread(DoWork)
            {
                IsBackground = true,
            };

            Output = default(TO);
            Exception = null;
            CancellationPending = false;

            Worker.Start(parameter);            
        }

        public void Cancel()
        {
            CancellationPending = true;
        }

        private void DoWork(object obj)
        {
            var input = (TI)obj;
            try
            {
                Output = Work(input);
            }
            catch (Exception exeption)
            {
                Exception = exeption;
            }
            
            Form.BeginInvoke((MethodInvoker)delegate
            {
                Complete(Output, CancellationPending, Exception);
            });
            Worker = null;
        }
    }
}