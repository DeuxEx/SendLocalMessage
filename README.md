Syntax for the tool:

SendLocalMessage.exe rubriktext="subjecttext"slutrubriktext brodtext="regulartext"slutbrodtext kontakttext="Contacts:"slutkontakttext telefontext="Phonenumber"sluttelefontext action=generate/show

The textfields parameters is named in Swedish, but hey I´m a Swedish developer :D

The parameter action= should probably always be generate.
When it is generate the textparameters will be checked so they are all filled with data, and when they are not null a Scheduled task is generated in the root of schtasks.
This tasks commandline property will have action=show in the syntax.
When the action=show is found by SendLocalMessage.exe it will change the execution function and instead of create a schtask it will populate a winform with the data that you send in via the commandline.

The code requires Dotnet Framework 4.8
