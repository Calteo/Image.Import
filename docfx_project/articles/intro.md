# Introduction

This simple program imports images and videos from a folder or drive into your system.
Currently it will import images with the extension *.jpg and videos with the extension *.mp4.

## Autoplay registration

In the menu File / Autoplay Registration you can register this program for autoplay. 
This way the programm will automatically show up as one of the options after inserting a sd card into your system with pictures on it.

## Source

For a source you can select any drive or folder. 
The source can be set from the command line with the option -source <folder>.

The autoplay registration will automatically set the source to the inserted drive.

As soon as the source is set it is scanned for possible files to import.

## Profiles

Beore importing there must be a selected profile. These can be edit via the Edit button.
Each profile consists of a name and two expressions. One for images and one for videos.

### Images
In the expression for images you specify where images will be saved.
This muss be a complete filename and it can contain placeholders, which are replaced by values of the current image.

These placeholder come in the syntax of ${name:format}. The format is optional.

* filename - the name of the imported file including its extension
* filedate - the timestamp of the last change of the imported file. 
			Here the format consists of patterns that format a DateTime object. 
			If no format is given then "yyyy-MM-dd-HH-mm-ss" is applied.
* taken - the timestamp when the image was taken
			Here the format consists of patterns that format a DateTime object. 
			If no format is given then "yyyy-MM-dd-HH-mm-ss" is applied.

Example: D:\Temp\ImageImport\${taken:yyyy-MM}\${filename}

This puts all images from the same month into one folder.

### Videos
In the expression for videos you specify where videos will be saved.
This muss be a complete filename and it can contain placeholders, which are replaced by values of the current video.

These placeholder come in the syntax of ${name:format}. The format is optional.

* filename - the name of the imported file including its extension
* filedate - the timestamp of the last change of the imported file. 
			Here the format consists of patterns that format a DateTime object. 
			If no format is given then "yyyy-MM-dd-HH-mm-ss" is applied.

Example: D:\Temp\VideoImport\${taken:yyyy}\${taken:yyyy}\${filename}

This puts all images from the same month into one folder wihich are out into a separate folder for every year.

## Options

### Overwrite exsiting files
Obviously this overwrites already existing files in the target folder. Otherwise existing files will be skipped.

### Only files newer than last import
If imported files are deleted in the target folder they would be reimported on the next run of an import. This might not be a wanted behaviour.
Therefore the program tries to save an import state on the source and if such a file is present then this option can be enabled.
If enabled only files that are newer than the last import are imported (hence the name of the option).

# Import
The import starts with the Import button and can be aborted while it is running.
Some progress messages are shown.


