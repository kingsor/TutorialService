﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://www.wstutorial.com/ws/TutorialService", ConfigurationName="TutorialServicePort")]
public interface TutorialServicePort
{
    
    // CODEGEN: Generating message contract since the operation getTutorials is neither RPC nor document wrapped.
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    getTutorialsResponse getTutorials(getTutorialsRequest1 request);
    
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    System.Threading.Tasks.Task<getTutorialsResponse> getTutorialsAsync(getTutorialsRequest1 request);
    
    // CODEGEN: Generating message contract since the operation updateTutorial is neither RPC nor document wrapped.
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    updateTutorialResponse1 updateTutorial(updateTutorialRequest1 request);
    
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    System.Threading.Tasks.Task<updateTutorialResponse1> updateTutorialAsync(updateTutorialRequest1 request);
    
    // CODEGEN: Generating message contract since the operation deleteTutorial is neither RPC nor document wrapped.
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    deleteTutorialResponse1 deleteTutorial(deleteTutorialRequest1 request);
    
    [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
    System.Threading.Tasks.Task<deleteTutorialResponse1> deleteTutorialAsync(deleteTutorialRequest1 request);
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.wstutorial.com/ws/TutorialService")]
public partial class getTutorialsRequest
{
    
    private long idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public long id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.wstutorial.com/ws/TutorialService")]
public partial class statusCode
{
    
    private long codeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public long code
    {
        get
        {
            return this.codeField;
        }
        set
        {
            this.codeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.wstutorial.com/ws/TutorialService")]
public partial class TutorialType
{
    
    private long idField;
    
    private string nameField;
    
    private string authorField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public long id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string author
    {
        get
        {
            return this.authorField;
        }
        set
        {
            this.authorField = value;
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class getTutorialsRequest1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.wstutorial.com/ws/TutorialService", Order=0)]
    public getTutorialsRequest getTutorialsRequest;
    
    public getTutorialsRequest1()
    {
    }
    
    public getTutorialsRequest1(getTutorialsRequest getTutorialsRequest)
    {
        this.getTutorialsRequest = getTutorialsRequest;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class getTutorialsResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Name="getTutorialsResponse", Namespace="http://www.wstutorial.com/ws/TutorialService", Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("tutorials", IsNullable=false)]
    public TutorialType[] getTutorialsResponse1;
    
    public getTutorialsResponse()
    {
    }
    
    public getTutorialsResponse(TutorialType[] getTutorialsResponse1)
    {
        this.getTutorialsResponse1 = getTutorialsResponse1;
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.wstutorial.com/ws/TutorialService")]
public partial class updateTutorialRequest
{
    
    private TutorialType tutorialTypeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public TutorialType tutorialType
    {
        get
        {
            return this.tutorialTypeField;
        }
        set
        {
            this.tutorialTypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.wstutorial.com/ws/TutorialService")]
public partial class updateTutorialResponse
{
    
    private statusCode statusCodeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public statusCode statusCode
    {
        get
        {
            return this.statusCodeField;
        }
        set
        {
            this.statusCodeField = value;
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class updateTutorialRequest1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.wstutorial.com/ws/TutorialService", Order=0)]
    public updateTutorialRequest updateTutorialRequest;
    
    public updateTutorialRequest1()
    {
    }
    
    public updateTutorialRequest1(updateTutorialRequest updateTutorialRequest)
    {
        this.updateTutorialRequest = updateTutorialRequest;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class updateTutorialResponse1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.wstutorial.com/ws/TutorialService", Order=0)]
    public updateTutorialResponse updateTutorialResponse;
    
    public updateTutorialResponse1()
    {
    }
    
    public updateTutorialResponse1(updateTutorialResponse updateTutorialResponse)
    {
        this.updateTutorialResponse = updateTutorialResponse;
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.wstutorial.com/ws/TutorialService")]
public partial class deleteTutorialRequest
{
    
    private long idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public long id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.wstutorial.com/ws/TutorialService")]
public partial class deleteTutorialResponse
{
    
    private statusCode statusCodeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public statusCode statusCode
    {
        get
        {
            return this.statusCodeField;
        }
        set
        {
            this.statusCodeField = value;
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class deleteTutorialRequest1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.wstutorial.com/ws/TutorialService", Order=0)]
    public deleteTutorialRequest deleteTutorialRequest;
    
    public deleteTutorialRequest1()
    {
    }
    
    public deleteTutorialRequest1(deleteTutorialRequest deleteTutorialRequest)
    {
        this.deleteTutorialRequest = deleteTutorialRequest;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
public partial class deleteTutorialResponse1
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.wstutorial.com/ws/TutorialService", Order=0)]
    public deleteTutorialResponse deleteTutorialResponse;
    
    public deleteTutorialResponse1()
    {
    }
    
    public deleteTutorialResponse1(deleteTutorialResponse deleteTutorialResponse)
    {
        this.deleteTutorialResponse = deleteTutorialResponse;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface TutorialServicePortChannel : TutorialServicePort, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class TutorialServicePortClient : System.ServiceModel.ClientBase<TutorialServicePort>, TutorialServicePort
{
    
    public TutorialServicePortClient()
    {
    }
    
    public TutorialServicePortClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public TutorialServicePortClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public TutorialServicePortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public TutorialServicePortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    getTutorialsResponse TutorialServicePort.getTutorials(getTutorialsRequest1 request)
    {
        return base.Channel.getTutorials(request);
    }
    
    public TutorialType[] getTutorials(getTutorialsRequest getTutorialsRequest)
    {
        getTutorialsRequest1 inValue = new getTutorialsRequest1();
        inValue.getTutorialsRequest = getTutorialsRequest;
        getTutorialsResponse retVal = ((TutorialServicePort)(this)).getTutorials(inValue);
        return retVal.getTutorialsResponse1;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<getTutorialsResponse> TutorialServicePort.getTutorialsAsync(getTutorialsRequest1 request)
    {
        return base.Channel.getTutorialsAsync(request);
    }
    
    public System.Threading.Tasks.Task<getTutorialsResponse> getTutorialsAsync(getTutorialsRequest getTutorialsRequest)
    {
        getTutorialsRequest1 inValue = new getTutorialsRequest1();
        inValue.getTutorialsRequest = getTutorialsRequest;
        return ((TutorialServicePort)(this)).getTutorialsAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    updateTutorialResponse1 TutorialServicePort.updateTutorial(updateTutorialRequest1 request)
    {
        return base.Channel.updateTutorial(request);
    }
    
    public updateTutorialResponse updateTutorial(updateTutorialRequest updateTutorialRequest)
    {
        updateTutorialRequest1 inValue = new updateTutorialRequest1();
        inValue.updateTutorialRequest = updateTutorialRequest;
        updateTutorialResponse1 retVal = ((TutorialServicePort)(this)).updateTutorial(inValue);
        return retVal.updateTutorialResponse;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<updateTutorialResponse1> TutorialServicePort.updateTutorialAsync(updateTutorialRequest1 request)
    {
        return base.Channel.updateTutorialAsync(request);
    }
    
    public System.Threading.Tasks.Task<updateTutorialResponse1> updateTutorialAsync(updateTutorialRequest updateTutorialRequest)
    {
        updateTutorialRequest1 inValue = new updateTutorialRequest1();
        inValue.updateTutorialRequest = updateTutorialRequest;
        return ((TutorialServicePort)(this)).updateTutorialAsync(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    deleteTutorialResponse1 TutorialServicePort.deleteTutorial(deleteTutorialRequest1 request)
    {
        return base.Channel.deleteTutorial(request);
    }
    
    public deleteTutorialResponse deleteTutorial(deleteTutorialRequest deleteTutorialRequest)
    {
        deleteTutorialRequest1 inValue = new deleteTutorialRequest1();
        inValue.deleteTutorialRequest = deleteTutorialRequest;
        deleteTutorialResponse1 retVal = ((TutorialServicePort)(this)).deleteTutorial(inValue);
        return retVal.deleteTutorialResponse;
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.Threading.Tasks.Task<deleteTutorialResponse1> TutorialServicePort.deleteTutorialAsync(deleteTutorialRequest1 request)
    {
        return base.Channel.deleteTutorialAsync(request);
    }
    
    public System.Threading.Tasks.Task<deleteTutorialResponse1> deleteTutorialAsync(deleteTutorialRequest deleteTutorialRequest)
    {
        deleteTutorialRequest1 inValue = new deleteTutorialRequest1();
        inValue.deleteTutorialRequest = deleteTutorialRequest;
        return ((TutorialServicePort)(this)).deleteTutorialAsync(inValue);
    }
}
