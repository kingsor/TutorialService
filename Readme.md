# TutorialService

This repo is the result of a project started for creating a java SOAP service from a WSDL file.

From that project was created a proxy class in C# in order to create a client for that service.

So there are three folder.

- TutorialServiceSpringSoap contains the SOAP Service created with Spring WS
- TutorialServiceWsdl contains the WSDL exposed by the SOAP Service and used to generate a C# proxy class thanks to `svcutil.exe` utility.
- TutorialServiceClient contains a solution with a console app that calls the SOAP Service

