# TutorialServiceWsdl

This folder contains the WSDL file exposed by SOAP Service.

From that WSDL file was generated a proxy class with `svcutil.exe` utility.

This is the command for generating the code:

```bash

svcutil.exe .\\TutorialService.wsdl

```

that generates `TutorialService.cs` and `output.config` files.

