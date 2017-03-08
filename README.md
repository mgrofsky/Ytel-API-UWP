# Getting started

## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (Message360.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Message360-CSharp&workspaceName=Message360&projectName=Message360.UWP)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the Message360 library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Message360-CSharp&workspaceName=Message360&projectName=Message360.UWP)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Message360-CSharp&workspaceName=Message360&projectName=Message360.UWP)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Message360-CSharp&workspaceName=Message360&projectName=Message360.UWP)

### 3. Add reference of the library project

In order to use the Message360 library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Message360-CSharp&workspaceName=Message360&projectName=Message360.UWP)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` Message360.UWP ``` and click ``` OK ```. By doing this, we have added a reference of the ```Message360.UWP``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Message360-CSharp&workspaceName=Message360&projectName=Message360.UWP)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Message360-CSharp&workspaceName=Message360&projectName=Message360.UWP)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| basicAuthUserName | The username to use with basic authentication |
| basicAuthPassword | The password to use with basic authentication |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

Message360Client client = new Message360Client(basicAuthUserName, basicAuthPassword);
```

## Class Reference

### <a name="list_of_controllers"></a>List of Controllers

* [ShortCodeController](#short_code_controller)
* [ConferenceController](#conference_controller)
* [EmailController](#email_controller)
* [NumberVerificationController](#number_verification_controller)
* [CarrierController](#carrier_controller)
* [CallController](#call_controller)
* [WebRTCController](#web_rtc_controller)
* [SubAccountController](#sub_account_controller)
* [AddressController](#address_controller)
* [PhoneNumberController](#phone_number_controller)
* [RecordingController](#recording_controller)
* [SMSController](#sms_controller)
* [TranscriptionController](#transcription_controller)
* [UsageController](#usage_controller)
* [AccountController](#account_controller)

### <a name="short_code_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.ShortCodeController") ShortCodeController

#### Get singleton instance

The singleton instance of the ``` ShortCodeController ``` class can be accessed from the API Client.

```csharp
ShortCodeController shortCode = client.ShortCode;
```

#### <a name="create_view_template"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ShortCodeController.CreateViewTemplate") CreateViewTemplate

> View a Shared ShortCode Template


```csharp
Task<string> CreateViewTemplate(CreateViewTemplateInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| templateid |  ``` Required ```  | The unique identifier for a template object |
| responseType |  ``` Required ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateViewTemplateInput collect = new CreateViewTemplateInput();

Guid templateid = Guid.NewGuid();
collect.Templateid = templateid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await shortCode.CreateViewTemplate(collect);

```


#### <a name="create_send_short_code"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ShortCodeController.CreateSendShortCode") CreateSendShortCode

> Send an SMS from a message360 ShortCode


```csharp
Task<string> CreateSendShortCode(CreateSendShortCodeInput input, Dictionary<string, object> fieldParameters = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| shortcode |  ``` Required ```  | The Short Code number that is the sender of this message |
| tocountrycode |  ``` Required ```  ``` DefaultValue ```  | The country code for sending this message |
| to |  ``` Required ```  | A valid 10-digit number that should receive the message+ |
| templateid |  ``` Required ```  | The unique identifier for the template used for the message |
| method |  ``` Optional ```  ``` DefaultValue ```  | Specifies the HTTP method used to request the required URL once the Short Code message is sent. |
| messageStatusCallback |  ``` Optional ```  | URL that can be requested to receive notification when Short Code message was sent. |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |
| fieldParameters | ``` Optional ``` | Additional optional form parameters are supported by this method |


#### Example Usage

```csharp
CreateSendShortCodeInput collect = new CreateSendShortCodeInput();

string shortcode = "shortcode";
collect.Shortcode = shortcode;

string tocountrycode = "1";
collect.Tocountrycode = tocountrycode;

string to = "to";
collect.To = to;

Guid templateid = Guid.NewGuid();
collect.Templateid = templateid;

string method = "GET";
collect.Method = method;

string messageStatusCallback = "MessageStatusCallback";
collect.MessageStatusCallback = messageStatusCallback;

string responseType = "json";
collect.ResponseType = responseType;

// key-value map for optional form parameters
var formParams = new Dictionary<string, object>();


string result = await shortCode.CreateSendShortCode(collect, formParams, );

```


#### <a name="create_list_inbound_short_code"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ShortCodeController.CreateListInboundShortCode") CreateListInboundShortCode

> List All Inbound ShortCode


```csharp
Task<string> CreateListInboundShortCode(CreateListInboundShortCodeInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Which page of the overall response will be returned. Zero indexed |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| mfrom |  ``` Optional ```  | From Number to Inbound ShortCode |
| shortcode |  ``` Optional ```  | Only list messages sent to this Short Code |
| dateReceived |  ``` Optional ```  | Only list messages sent with the specified date |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateListInboundShortCodeInput collect = new CreateListInboundShortCodeInput();

int? page = 74;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string mfrom = "from";
collect.Mfrom = mfrom;

string shortcode = "Shortcode";
collect.Shortcode = shortcode;

string dateReceived = "DateReceived";
collect.DateReceived = dateReceived;

string responseType = "json";
collect.ResponseType = responseType;


string result = await shortCode.CreateListInboundShortCode(collect);

```


#### <a name="create_list_short_code"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ShortCodeController.CreateListShortCode") CreateListShortCode

> List ShortCode Messages


```csharp
Task<string> CreateListShortCode(CreateListShortCodeInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Which page of the overall response will be returned. Zero indexed |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| mfrom |  ``` Optional ```  | Messages sent from this number |
| to |  ``` Optional ```  | Messages sent to this number |
| datesent |  ``` Optional ```  | Only list SMS messages sent in the specified date range |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateListShortCodeInput collect = new CreateListShortCodeInput();

int? page = 74;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string mfrom = "from";
collect.Mfrom = mfrom;

string to = "to";
collect.To = to;

string datesent = "datesent";
collect.Datesent = datesent;

string responseType = "json";
collect.ResponseType = responseType;


string result = await shortCode.CreateListShortCode(collect);

```


#### <a name="create_list_templates"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ShortCodeController.CreateListTemplates") CreateListTemplates

> List Shortcode Templates by Type


```csharp
Task<string> CreateListTemplates(CreateListTemplatesInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| type |  ``` Optional ```  ``` DefaultValue ```  | The type (category) of template Valid values: marketing, authorization |
| page |  ``` Optional ```  | The page count to retrieve from the total results in the collection. Page indexing starts at 1. |
| pagesize |  ``` Optional ```  ``` DefaultValue ```  | The count of objects to return per page. |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateListTemplatesInput collect = new CreateListTemplatesInput();

string type = "authorization";
collect.Type = type;

int? page = 74;
collect.Page = page;

int? pagesize = 10;
collect.Pagesize = pagesize;

string responseType = "json";
collect.ResponseType = responseType;


string result = await shortCode.CreateListTemplates(collect);

```


#### <a name="create_view_short_code"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ShortCodeController.CreateViewShortCode") CreateViewShortCode

> View a ShortCode Message


```csharp
Task<string> CreateViewShortCode(CreateViewShortCodeInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| messagesid |  ``` Required ```  | Message sid |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateViewShortCodeInput collect = new CreateViewShortCodeInput();

string messagesid = "messagesid";
collect.Messagesid = messagesid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await shortCode.CreateViewShortCode(collect);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="conference_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.ConferenceController") ConferenceController

#### Get singleton instance

The singleton instance of the ``` ConferenceController ``` class can be accessed from the API Client.

```csharp
ConferenceController conference = client.Conference;
```

#### <a name="create_deaf_mute_participant"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ConferenceController.CreateDeafMuteParticipant") CreateDeafMuteParticipant

> Deaf Mute Participant


```csharp
Task<string> CreateDeafMuteParticipant(CreateDeafMuteParticipantInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | TODO: Add a parameter description |
| participantSid |  ``` Required ```  | TODO: Add a parameter description |
| muted |  ``` Optional ```  | TODO: Add a parameter description |
| deaf |  ``` Optional ```  | TODO: Add a parameter description |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response Type either json or xml |


#### Example Usage

```csharp
CreateDeafMuteParticipantInput collect = new CreateDeafMuteParticipantInput();

string conferenceSid = "conferenceSid";
collect.ConferenceSid = conferenceSid;

string participantSid = "ParticipantSid";
collect.ParticipantSid = participantSid;

bool? muted = false;
collect.Muted = muted;

bool? deaf = false;
collect.Deaf = deaf;

string responseType = "json";
collect.ResponseType = responseType;


string result = await conference.CreateDeafMuteParticipant(collect);

```


#### <a name="create_list_conference"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ConferenceController.CreateListConference") CreateListConference

> List Conference


```csharp
Task<string> CreateListConference(CreateListConferenceInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Which page of the overall response will be returned. Zero indexed |
| pageSize |  ``` Optional ```  | Number of individual resources listed in the response per page |
| friendlyName |  ``` Optional ```  | Only return conferences with the specified FriendlyName |
| status |  ``` Optional ```  | TODO: Add a parameter description |
| dateCreated |  ``` Optional ```  | TODO: Add a parameter description |
| dateUpdated |  ``` Optional ```  | TODO: Add a parameter description |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateListConferenceInput collect = new CreateListConferenceInput();

int? page = 74;
collect.Page = page;

int? pageSize = 74;
collect.PageSize = pageSize;

string friendlyName = "FriendlyName";
collect.FriendlyName = friendlyName;

var status = Models.InterruptedCallStatus?Helper.ParseString("CANCELED");
collect.Status = status;

string dateCreated = "DateCreated";
collect.DateCreated = dateCreated;

string dateUpdated = "DateUpdated";
collect.DateUpdated = dateUpdated;

string responseType = "json";
collect.ResponseType = responseType;


string result = await conference.CreateListConference(collect);

```


#### <a name="create_view_conference"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ConferenceController.CreateViewConference") CreateViewConference

> View Conference


```csharp
Task<string> CreateViewConference(CreateViewConferenceInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferencesid |  ``` Required ```  | The unique identifier of each conference resource |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateViewConferenceInput collect = new CreateViewConferenceInput();

string conferencesid = "conferencesid";
collect.Conferencesid = conferencesid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await conference.CreateViewConference(collect);

```


#### <a name="add_participant"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ConferenceController.AddParticipant") AddParticipant

> Add Participant in conference 


```csharp
Task<string> AddParticipant(AddParticipantInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferencesid |  ``` Required ```  | Unique Conference Sid |
| participantnumber |  ``` Required ```  | Particiant Number |
| tocountrycode |  ``` Required ```  | TODO: Add a parameter description |
| muted |  ``` Optional ```  | TODO: Add a parameter description |
| deaf |  ``` Optional ```  | TODO: Add a parameter description |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
AddParticipantInput collect = new AddParticipantInput();

string conferencesid = "conferencesid";
collect.Conferencesid = conferencesid;

string participantnumber = "participantnumber";
collect.Participantnumber = participantnumber;

int tocountrycode = 74;
collect.Tocountrycode = tocountrycode;

bool? muted = false;
collect.Muted = muted;

bool? deaf = false;
collect.Deaf = deaf;

string responseType = "json";
collect.ResponseType = responseType;


string result = await conference.AddParticipant(collect);

```


#### <a name="create_list_participant"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ConferenceController.CreateListParticipant") CreateListParticipant

> List Participant


```csharp
Task<string> CreateListParticipant(CreateListParticipantInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | unique conference sid |
| page |  ``` Optional ```  | page number |
| pagesize |  ``` Optional ```  | TODO: Add a parameter description |
| muted |  ``` Optional ```  | TODO: Add a parameter description |
| deaf |  ``` Optional ```  | TODO: Add a parameter description |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
CreateListParticipantInput collect = new CreateListParticipantInput();

string conferenceSid = "ConferenceSid";
collect.ConferenceSid = conferenceSid;

int? page = 74;
collect.Page = page;

int? pagesize = 74;
collect.Pagesize = pagesize;

bool? muted = false;
collect.Muted = muted;

bool? deaf = false;
collect.Deaf = deaf;

string responseType = "json";
collect.ResponseType = responseType;


string result = await conference.CreateListParticipant(collect);

```


#### <a name="create_view_participant"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.ConferenceController.CreateViewParticipant") CreateViewParticipant

> View Participant


```csharp
Task<string> CreateViewParticipant(CreateViewParticipantInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| conferenceSid |  ``` Required ```  | unique conference sid |
| participantSid |  ``` Required ```  | TODO: Add a parameter description |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateViewParticipantInput collect = new CreateViewParticipantInput();

string conferenceSid = "ConferenceSid";
collect.ConferenceSid = conferenceSid;

string participantSid = "ParticipantSid";
collect.ParticipantSid = participantSid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await conference.CreateViewParticipant(collect);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="email_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.EmailController") EmailController

#### Get singleton instance

The singleton instance of the ``` EmailController ``` class can be accessed from the API Client.

```csharp
EmailController email = client.Email;
```

#### <a name="create_delete_invalid"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.CreateDeleteInvalid") CreateDeleteInvalid

> This endpoint allows you to delete entries in the Invalid Emails list.


```csharp
Task<string> CreateDeleteInvalid(CreateDeleteInvalidInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | TODO: Add a parameter description |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
CreateDeleteInvalidInput collect = new CreateDeleteInvalidInput();

string email = "email";
collect.Email = email;

string responseType = "json";
collect.ResponseType = responseType;


string result = await email.CreateDeleteInvalid(collect);

```


#### <a name="create_list_blocks"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.CreateListBlocks") CreateListBlocks

> Outputs email addresses on your blocklist


```csharp
Task<string> CreateListBlocks(CreateListBlocksInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| offset |  ``` Optional ```  | Where to start in the output list |
| limit |  ``` Optional ```  | Maximum number of records to return |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateListBlocksInput collect = new CreateListBlocksInput();

string offset = "offset";
collect.Offset = offset;

string limit = "limit";
collect.Limit = limit;

string responseType = "json";
collect.ResponseType = responseType;


string result = await email.CreateListBlocks(collect);

```


#### <a name="create_list_spam"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.CreateListSpam") CreateListSpam

> List out all email addresses marked as spam


```csharp
Task<string> CreateListSpam(CreateListSpamInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |
| offset |  ``` Optional ```  | The record number to start the list at |
| limit |  ``` Optional ```  | Maximum number of records to return |


#### Example Usage

```csharp
CreateListSpamInput collect = new CreateListSpamInput();

string responseType = "json";
collect.ResponseType = responseType;

string offset = "offset";
collect.Offset = offset;

string limit = "limit";
collect.Limit = limit;


string result = await email.CreateListSpam(collect);

```


#### <a name="create_list_bounces"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.CreateListBounces") CreateListBounces

> List out all email addresses that have bounced


```csharp
Task<string> CreateListBounces(CreateListBouncesInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |
| offset |  ``` Optional ```  | The record to start the list at |
| limit |  ``` Optional ```  | The maximum number of records to return |


#### Example Usage

```csharp
CreateListBouncesInput collect = new CreateListBouncesInput();

string responseType = "json";
collect.ResponseType = responseType;

string offset = "offset";
collect.Offset = offset;

string limit = "limit";
collect.Limit = limit;


string result = await email.CreateListBounces(collect);

```


#### <a name="create_delete_bounces"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.CreateDeleteBounces") CreateDeleteBounces

> Delete an email address from the bounced address list


```csharp
Task<string> CreateDeleteBounces(CreateDeleteBouncesInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | The email address to remove from the bounce list |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateDeleteBouncesInput collect = new CreateDeleteBouncesInput();

string email = "email";
collect.Email = email;

string responseType = "json";
collect.ResponseType = responseType;


string result = await email.CreateDeleteBounces(collect);

```


#### <a name="create_list_invalid"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.CreateListInvalid") CreateListInvalid

> List out all invalid email addresses


```csharp
Task<string> CreateListInvalid(CreateListInvalidInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |
| offet |  ``` Optional ```  | Starting record for listing out emails |
| limit |  ``` Optional ```  | Maximum number of records to return |


#### Example Usage

```csharp
CreateListInvalidInput collect = new CreateListInvalidInput();

string responseType = "json";
collect.ResponseType = responseType;

string offet = "offet";
collect.Offet = offet;

string limit = "limit";
collect.Limit = limit;


string result = await email.CreateListInvalid(collect);

```


#### <a name="create_list_unsubscribes"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.CreateListUnsubscribes") CreateListUnsubscribes

> List all unsubscribed email addresses


```csharp
Task<string> CreateListUnsubscribes(CreateListUnsubscribesInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |
| offset |  ``` Optional ```  | Starting record of the list |
| limit |  ``` Optional ```  | Maximum number of records to be returned |


#### Example Usage

```csharp
CreateListUnsubscribesInput collect = new CreateListUnsubscribesInput();

string responseType = "json";
collect.ResponseType = responseType;

string offset = "offset";
collect.Offset = offset;

string limit = "limit";
collect.Limit = limit;


string result = await email.CreateListUnsubscribes(collect);

```


#### <a name="create_delete_unsubscribes"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.CreateDeleteUnsubscribes") CreateDeleteUnsubscribes

> Delete emails from the unsubscribe list


```csharp
Task<string> CreateDeleteUnsubscribes(CreateDeleteUnsubscribesInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | The email to remove from the unsubscribe list |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateDeleteUnsubscribesInput collect = new CreateDeleteUnsubscribesInput();

string email = "email";
collect.Email = email;

string responseType = "json";
collect.ResponseType = responseType;


string result = await email.CreateDeleteUnsubscribes(collect);

```


#### <a name="add_unsubscribes"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.AddUnsubscribes") AddUnsubscribes

> Add an email to the unsubscribe list


```csharp
Task<string> AddUnsubscribes(AddUnsubscribesInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | The email to add to the unsubscribe list |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
AddUnsubscribesInput collect = new AddUnsubscribesInput();

string email = "email";
collect.Email = email;

string responseType = "json";
collect.ResponseType = responseType;


string result = await email.AddUnsubscribes(collect);

```


#### <a name="create_delete_block"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.CreateDeleteBlock") CreateDeleteBlock

> Deletes a blocked email


```csharp
Task<string> CreateDeleteBlock(CreateDeleteBlockInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | Email address to remove from block list |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateDeleteBlockInput collect = new CreateDeleteBlockInput();

string email = "email";
collect.Email = email;

string responseType = "json";
collect.ResponseType = responseType;


string result = await email.CreateDeleteBlock(collect);

```


#### <a name="create_delete_spam"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.CreateDeleteSpam") CreateDeleteSpam

> Deletes a email address marked as spam from the spam list


```csharp
Task<string> CreateDeleteSpam(CreateDeleteSpamInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| email |  ``` Required ```  | Email address |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateDeleteSpamInput collect = new CreateDeleteSpamInput();

string email = "email";
collect.Email = email;

string responseType = "json";
collect.ResponseType = responseType;


string result = await email.CreateDeleteSpam(collect);

```


#### <a name="create_send_email"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.EmailController.CreateSendEmail") CreateSendEmail

> Send out an email


```csharp
Task<string> CreateSendEmail(CreateSendEmailInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| to |  ``` Required ```  | The to email address |
| mfrom |  ``` Required ```  | The from email address |
| type |  ``` Required ```  ``` DefaultValue ```  | email format type, html or text |
| subject |  ``` Required ```  | Email subject |
| message |  ``` Required ```  | The body of the email message |
| cc |  ``` Optional ```  | CC Email address |
| bcc |  ``` Optional ```  | BCC Email address |
| attachment |  ``` Optional ```  | File to be attached.File must be less than 7MB. |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateSendEmailInput collect = new CreateSendEmailInput();

string to = "to";
collect.To = to;

string mfrom = "from";
collect.Mfrom = mfrom;

var type = Models.SendEmailAsHelper.ParseString("HTML");
collect.Type = type;

string subject = "subject";
collect.Subject = subject;

string message = "message";
collect.Message = message;

string cc = "cc";
collect.Cc = cc;

string bcc = "bcc";
collect.Bcc = bcc;

string attachment = "attachment";
collect.Attachment = attachment;

string responseType = "json";
collect.ResponseType = responseType;


string result = await email.CreateSendEmail(collect);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="number_verification_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.NumberVerificationController") NumberVerificationController

#### Get singleton instance

The singleton instance of the ``` NumberVerificationController ``` class can be accessed from the API Client.

```csharp
NumberVerificationController numberVerification = client.NumberVerification;
```

#### <a name="create_verify_number"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.NumberVerificationController.CreateVerifyNumber") CreateVerifyNumber

> Number Verification


```csharp
Task<string> CreateVerifyNumber(CreateVerifyNumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phonenumber |  ``` Required ```  | TODO: Add a parameter description |
| type |  ``` Required ```  | TODO: Add a parameter description |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response Type either json or xml |


#### Example Usage

```csharp
CreateVerifyNumberInput collect = new CreateVerifyNumberInput();

string phonenumber = "phonenumber";
collect.Phonenumber = phonenumber;

string type = "type";
collect.Type = type;

string responseType = "json";
collect.ResponseType = responseType;


string result = await numberVerification.CreateVerifyNumber(collect);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="carrier_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.CarrierController") CarrierController

#### Get singleton instance

The singleton instance of the ``` CarrierController ``` class can be accessed from the API Client.

```csharp
CarrierController carrier = client.Carrier;
```

#### <a name="create_carrier_lookup"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.CarrierController.CreateCarrierLookup") CreateCarrierLookup

> Get the Carrier Lookup


```csharp
Task<string> CreateCarrierLookup(CreateCarrierLookupInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phonenumber |  ``` Required ```  | The number to lookup |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateCarrierLookupInput collect = new CreateCarrierLookupInput();

string phonenumber = "phonenumber";
collect.Phonenumber = phonenumber;

string responseType = "json";
collect.ResponseType = responseType;


string result = await carrier.CreateCarrierLookup(collect);

```


#### <a name="create_carrier_lookup_list"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.CarrierController.CreateCarrierLookupList") CreateCarrierLookupList

> Get the All Purchase Number's Carrier lookup


```csharp
Task<string> CreateCarrierLookupList(CreateCarrierLookupListInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Page Number |
| pagesize |  ``` Optional ```  | Page Size |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateCarrierLookupListInput collect = new CreateCarrierLookupListInput();

int? page = 32;
collect.Page = page;

int? pagesize = 32;
collect.Pagesize = pagesize;

string responseType = "json";
collect.ResponseType = responseType;


string result = await carrier.CreateCarrierLookupList(collect);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="call_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.CallController") CallController

#### Get singleton instance

The singleton instance of the ``` CallController ``` class can be accessed from the API Client.

```csharp
CallController call = client.Call;
```

#### <a name="create_view_call"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.CallController.CreateViewCall") CreateViewCall

> View Call Response


```csharp
Task<string> CreateViewCall(CreateViewCallInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callsid |  ``` Required ```  | Call Sid id for particular Call |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateViewCallInput collect = new CreateViewCallInput();

string callsid = "callsid";
collect.Callsid = callsid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await call.CreateViewCall(collect);

```


#### <a name="create_group_call"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.CallController.CreateGroupCall") CreateGroupCall

> Group Call


```csharp
Task<string> CreateGroupCall(CreateGroupCallInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| fromCountryCode |  ``` Required ```  ``` DefaultValue ```  | TODO: Add a parameter description |
| mfrom |  ``` Required ```  | TODO: Add a parameter description |
| toCountryCode |  ``` Required ```  ``` DefaultValue ```  | TODO: Add a parameter description |
| to |  ``` Required ```  | TODO: Add a parameter description |
| url |  ``` Required ```  | TODO: Add a parameter description |
| method |  ``` Optional ```  | TODO: Add a parameter description |
| statusCallBackUrl |  ``` Optional ```  | TODO: Add a parameter description |
| statusCallBackMethod |  ``` Optional ```  | TODO: Add a parameter description |
| fallBackUrl |  ``` Optional ```  | TODO: Add a parameter description |
| fallBackMethod |  ``` Optional ```  | TODO: Add a parameter description |
| heartBeatUrl |  ``` Optional ```  | TODO: Add a parameter description |
| heartBeatMethod |  ``` Optional ```  | TODO: Add a parameter description |
| timeout |  ``` Optional ```  | TODO: Add a parameter description |
| playDtmf |  ``` Optional ```  | TODO: Add a parameter description |
| hideCallerId |  ``` Optional ```  | TODO: Add a parameter description |
| record |  ``` Optional ```  | TODO: Add a parameter description |
| recordCallBackUrl |  ``` Optional ```  | TODO: Add a parameter description |
| recordCallBackMethod |  ``` Optional ```  | TODO: Add a parameter description |
| transcribe |  ``` Optional ```  | TODO: Add a parameter description |
| transcribeCallBackUrl |  ``` Optional ```  | TODO: Add a parameter description |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
CreateGroupCallInput collect = new CreateGroupCallInput();

string fromCountryCode = "1";
collect.FromCountryCode = fromCountryCode;

string mfrom = "From";
collect.Mfrom = mfrom;

string toCountryCode = "1";
collect.ToCountryCode = toCountryCode;

string to = "To";
collect.To = to;

string url = "Url";
collect.Url = url;

var method = Models.HttpAction?Helper.ParseString("GET");
collect.Method = method;

string statusCallBackUrl = "StatusCallBackUrl";
collect.StatusCallBackUrl = statusCallBackUrl;

var statusCallBackMethod = Models.HttpAction?Helper.ParseString("GET");
collect.StatusCallBackMethod = statusCallBackMethod;

string fallBackUrl = "FallBackUrl";
collect.FallBackUrl = fallBackUrl;

var fallBackMethod = Models.HttpAction?Helper.ParseString("GET");
collect.FallBackMethod = fallBackMethod;

string heartBeatUrl = "HeartBeatUrl";
collect.HeartBeatUrl = heartBeatUrl;

var heartBeatMethod = Models.HttpAction?Helper.ParseString("GET");
collect.HeartBeatMethod = heartBeatMethod;

int? timeout = 32;
collect.Timeout = timeout;

string playDtmf = "PlayDtmf";
collect.PlayDtmf = playDtmf;

string hideCallerId = "HideCallerId";
collect.HideCallerId = hideCallerId;

bool? record = false;
collect.Record = record;

string recordCallBackUrl = "RecordCallBackUrl";
collect.RecordCallBackUrl = recordCallBackUrl;

var recordCallBackMethod = Models.HttpAction?Helper.ParseString("GET");
collect.RecordCallBackMethod = recordCallBackMethod;

bool? transcribe = false;
collect.Transcribe = transcribe;

string transcribeCallBackUrl = "TranscribeCallBackUrl";
collect.TranscribeCallBackUrl = transcribeCallBackUrl;

string responseType = "json";
collect.ResponseType = responseType;


string result = await call.CreateGroupCall(collect);

```


#### <a name="create_voice_effect"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.CallController.CreateVoiceEffect") CreateVoiceEffect

> Voice Effect


```csharp
Task<string> CreateVoiceEffect(CreateVoiceEffectInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | TODO: Add a parameter description |
| audioDirection |  ``` Optional ```  | TODO: Add a parameter description |
| pitchSemiTones |  ``` Optional ```  | value between -14 and 14 |
| pitchOctaves |  ``` Optional ```  | value between -1 and 1 |
| pitch |  ``` Optional ```  | value greater than 0 |
| rate |  ``` Optional ```  | value greater than 0 |
| tempo |  ``` Optional ```  | value greater than 0 |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateVoiceEffectInput collect = new CreateVoiceEffectInput();

string callSid = "CallSid";
collect.CallSid = callSid;

var audioDirection = Models.AudioDirection?Helper.ParseString("IN");
collect.AudioDirection = audioDirection;

double? pitchSemiTones = 32.7157483635078;
collect.PitchSemiTones = pitchSemiTones;

double? pitchOctaves = 32.7157483635078;
collect.PitchOctaves = pitchOctaves;

double? pitch = 32.7157483635078;
collect.Pitch = pitch;

double? rate = 32.7157483635078;
collect.Rate = rate;

double? tempo = 32.7157483635078;
collect.Tempo = tempo;

string responseType = "json";
collect.ResponseType = responseType;


string result = await call.CreateVoiceEffect(collect);

```


#### <a name="create_record_call"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.CallController.CreateRecordCall") CreateRecordCall

> Record a Call


```csharp
Task<string> CreateRecordCall(CreateRecordCallInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | The unique identifier of each call resource |
| record |  ``` Required ```  | Set true to initiate recording or false to terminate recording |
| direction |  ``` Optional ```  | The leg of the call to record |
| timeLimit |  ``` Optional ```  | Time in seconds the recording duration should not exceed |
| callBackUrl |  ``` Optional ```  | URL consulted after the recording completes |
| fileformat |  ``` Optional ```  | Format of the recording file. Can be .mp3 or .wav |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response format, xml or json |


#### Example Usage

```csharp
CreateRecordCallInput collect = new CreateRecordCallInput();

string callSid = "CallSid";
collect.CallSid = callSid;

bool record = false;
collect.Record = record;

var direction = Models.Direction?Helper.ParseString("IN");
collect.Direction = direction;

int? timeLimit = 32;
collect.TimeLimit = timeLimit;

string callBackUrl = "CallBackUrl";
collect.CallBackUrl = callBackUrl;

var fileformat = Models.AudioFormat?Helper.ParseString("mp3");
collect.Fileformat = fileformat;

string responseType = "json";
collect.ResponseType = responseType;


string result = await call.CreateRecordCall(collect);

```


#### <a name="create_play_audio"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.CallController.CreatePlayAudio") CreatePlayAudio

> Play Dtmf and send the Digit


```csharp
Task<string> CreatePlayAudio(CreatePlayAudioInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | The unique identifier of each call resource |
| audioUrl |  ``` Required ```  | URL to sound that should be played. You also can add more than one audio file using semicolons e.g. http://example.com/audio1.mp3;http://example.com/audio2.wav |
| length |  ``` Optional ```  | Time limit in seconds for audio play back |
| direction |  ``` Optional ```  | The leg of the call audio will be played to |
| loop |  ``` Optional ```  | Repeat audio playback indefinitely |
| mix |  ``` Optional ```  | If false, all other audio will be muted |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreatePlayAudioInput collect = new CreatePlayAudioInput();

string callSid = "CallSid";
collect.CallSid = callSid;

string audioUrl = "AudioUrl";
collect.AudioUrl = audioUrl;

int? length = 32;
collect.Length = length;

var direction = Models.Direction?Helper.ParseString("IN");
collect.Direction = direction;

bool? loop = false;
collect.Loop = loop;

bool? mix = false;
collect.Mix = mix;

string responseType = "json";
collect.ResponseType = responseType;


string result = await call.CreatePlayAudio(collect);

```


#### <a name="create_interrupted_call"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.CallController.CreateInterruptedCall") CreateInterruptedCall

> Interrupt the Call by Call Sid


```csharp
Task<string> CreateInterruptedCall(CreateInterruptedCallInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | Call SId |
| url |  ``` Optional ```  | URL the in-progress call will be redirected to |
| method |  ``` Optional ```  | The method used to request the above Url parameter |
| status |  ``` Optional ```  | Status to set the in-progress call to |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateInterruptedCallInput collect = new CreateInterruptedCallInput();

string callSid = "CallSid";
collect.CallSid = callSid;

string url = "Url";
collect.Url = url;

var method = Models.HttpAction?Helper.ParseString("GET");
collect.Method = method;

var status = Models.InterruptedCallStatus?Helper.ParseString("CANCELED");
collect.Status = status;

string responseType = "json";
collect.ResponseType = responseType;


string result = await call.CreateInterruptedCall(collect);

```


#### <a name="create_send_digit"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.CallController.CreateSendDigit") CreateSendDigit

> Play Dtmf and send the Digit


```csharp
Task<string> CreateSendDigit(CreateSendDigitInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| callSid |  ``` Required ```  | The unique identifier of each call resource |
| playDtmf |  ``` Required ```  | DTMF digits to play to the call. 0-9, #, *, W, or w |
| playDtmfDirection |  ``` Optional ```  | The leg of the call DTMF digits should be sent to |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateSendDigitInput collect = new CreateSendDigitInput();

string callSid = "CallSid";
collect.CallSid = callSid;

string playDtmf = "PlayDtmf";
collect.PlayDtmf = playDtmf;

var playDtmfDirection = Models.Direction?Helper.ParseString("IN");
collect.PlayDtmfDirection = playDtmfDirection;

string responseType = "json";
collect.ResponseType = responseType;


string result = await call.CreateSendDigit(collect);

```


#### <a name="create_make_call"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.CallController.CreateMakeCall") CreateMakeCall

> You can experiment with initiating a call through Message360 and view the request response generated when doing so and get the response in json


```csharp
Task<string> CreateMakeCall(CreateMakeCallInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| fromCountryCode |  ``` Required ```  | from country code |
| mfrom |  ``` Required ```  | This number to display on Caller ID as calling |
| toCountryCode |  ``` Required ```  | To cuntry code number |
| to |  ``` Required ```  | To number |
| url |  ``` Required ```  | URL requested once the call connects |
| method |  ``` Optional ```  | Specifies the HTTP method used to request the required URL once call connects. |
| statusCallBackUrl |  ``` Optional ```  | specifies the HTTP methodlinkclass used to request StatusCallbackUrl. |
| statusCallBackMethod |  ``` Optional ```  | Specifies the HTTP methodlinkclass used to request StatusCallbackUrl. |
| fallBackUrl |  ``` Optional ```  | URL requested if the initial Url parameter fails or encounters an error |
| fallBackMethod |  ``` Optional ```  | Specifies the HTTP method used to request the required FallbackUrl once call connects. |
| heartBeatUrl |  ``` Optional ```  | URL that can be requested every 60 seconds during the call to notify of elapsed tim |
| heartBeatMethod |  ``` Optional ```  | Specifies the HTTP method used to request HeartbeatUrl. |
| timeout |  ``` Optional ```  | Time (in seconds) Message360 should wait while the call is ringing before canceling the call |
| playDtmf |  ``` Optional ```  | DTMF Digits to play to the call once it connects. 0-9, #, or * |
| hideCallerId |  ``` Optional ```  | Specifies if the caller id will be hidden |
| record |  ``` Optional ```  | Specifies if the call should be recorded |
| recordCallBackUrl |  ``` Optional ```  | Recording parameters will be sent here upon completion |
| recordCallBackMethod |  ``` Optional ```  | Method used to request the RecordCallback URL. |
| transcribe |  ``` Optional ```  | Specifies if the call recording should be transcribed |
| transcribeCallBackUrl |  ``` Optional ```  | Transcription parameters will be sent here upon completion |
| ifMachine |  ``` Optional ```  | How Message360 should handle the receiving numbers voicemail machine |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateMakeCallInput collect = new CreateMakeCallInput();

string fromCountryCode = "FromCountryCode";
collect.FromCountryCode = fromCountryCode;

string mfrom = "From";
collect.Mfrom = mfrom;

string toCountryCode = "ToCountryCode";
collect.ToCountryCode = toCountryCode;

string to = "To";
collect.To = to;

string url = "Url";
collect.Url = url;

var method = Models.HttpAction?Helper.ParseString("GET");
collect.Method = method;

string statusCallBackUrl = "StatusCallBackUrl";
collect.StatusCallBackUrl = statusCallBackUrl;

var statusCallBackMethod = Models.HttpAction?Helper.ParseString("GET");
collect.StatusCallBackMethod = statusCallBackMethod;

string fallBackUrl = "FallBackUrl";
collect.FallBackUrl = fallBackUrl;

var fallBackMethod = Models.HttpAction?Helper.ParseString("GET");
collect.FallBackMethod = fallBackMethod;

string heartBeatUrl = "HeartBeatUrl";
collect.HeartBeatUrl = heartBeatUrl;

bool? heartBeatMethod = false;
collect.HeartBeatMethod = heartBeatMethod;

int? timeout = 32;
collect.Timeout = timeout;

string playDtmf = "PlayDtmf";
collect.PlayDtmf = playDtmf;

bool? hideCallerId = false;
collect.HideCallerId = hideCallerId;

bool? record = false;
collect.Record = record;

string recordCallBackUrl = "RecordCallBackUrl";
collect.RecordCallBackUrl = recordCallBackUrl;

var recordCallBackMethod = Models.HttpAction?Helper.ParseString("GET");
collect.RecordCallBackMethod = recordCallBackMethod;

bool? transcribe = false;
collect.Transcribe = transcribe;

string transcribeCallBackUrl = "TranscribeCallBackUrl";
collect.TranscribeCallBackUrl = transcribeCallBackUrl;

var ifMachine = Models.IfMachine?Helper.ParseString("CONTINUE");
collect.IfMachine = ifMachine;

string responseType = "json";
collect.ResponseType = responseType;


string result = await call.CreateMakeCall(collect);

```


#### <a name="create_list_calls"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.CallController.CreateListCalls") CreateListCalls

> A list of calls associated with your Message360 account


```csharp
Task<string> CreateListCalls(CreateListCallsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Which page of the overall response will be returned. Zero indexed |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| to |  ``` Optional ```  | Only list calls to this number |
| mfrom |  ``` Optional ```  | Only list calls from this number |
| dateCreated |  ``` Optional ```  | Only list calls starting within the specified date range |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateListCallsInput collect = new CreateListCallsInput();

int? page = 32;
collect.Page = page;

int? pageSize = 10;
collect.PageSize = pageSize;

string to = "To";
collect.To = to;

string mfrom = "From";
collect.Mfrom = mfrom;

string dateCreated = "DateCreated";
collect.DateCreated = dateCreated;

string responseType = "json";
collect.ResponseType = responseType;


string result = await call.CreateListCalls(collect);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="web_rtc_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.WebRTCController") WebRTCController

#### Get singleton instance

The singleton instance of the ``` WebRTCController ``` class can be accessed from the API Client.

```csharp
WebRTCController webRTC = client.WebRTC;
```

#### <a name="create_check_funds"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.WebRTCController.CreateCheckFunds") CreateCheckFunds

> TODO: Add a method description


```csharp
Task<string> CreateCheckFunds(CreateCheckFundsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountSid |  ``` Required ```  | Your message360 Account SID |
| authToken |  ``` Required ```  | Your message360 Token |


#### Example Usage

```csharp
CreateCheckFundsInput collect = new CreateCheckFundsInput();

string accountSid = "account_sid";
collect.AccountSid = accountSid;

string authToken = "auth_token";
collect.AuthToken = authToken;


string result = await webRTC.CreateCheckFunds(collect);

```


#### <a name="create_token"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.WebRTCController.CreateToken") CreateToken

> message360 webrtc


```csharp
Task<string> CreateToken(CreateTokenInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountSid |  ``` Required ```  | Your message360 Account SID |
| authToken |  ``` Required ```  | Your message360 Token |
| username |  ``` Required ```  | WebRTC username authentication |
| password |  ``` Required ```  | WebRTC password authentication |


#### Example Usage

```csharp
CreateTokenInput collect = new CreateTokenInput();

string accountSid = "account_sid";
collect.AccountSid = accountSid;

string authToken = "auth_token";
collect.AuthToken = authToken;

string username = "username";
collect.Username = username;

string password = "password";
collect.Password = password;


string result = await webRTC.CreateToken(collect);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="sub_account_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.SubAccountController") SubAccountController

#### Get singleton instance

The singleton instance of the ``` SubAccountController ``` class can be accessed from the API Client.

```csharp
SubAccountController subAccount = client.SubAccount;
```

#### <a name="create_sub_account"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SubAccountController.CreateSubAccount") CreateSubAccount

> Create a sub user account under the parent account


```csharp
Task<string> CreateSubAccount(CreateSubAccountInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| firstName |  ``` Required ```  | Sub account user first name |
| lastName |  ``` Required ```  | sub account user last name |
| email |  ``` Required ```  | Sub account email address |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateSubAccountInput collect = new CreateSubAccountInput();

string firstName = "FirstName";
collect.FirstName = firstName;

string lastName = "LastName";
collect.LastName = lastName;

string email = "Email";
collect.Email = email;

string responseType = "json";
collect.ResponseType = responseType;


string result = await subAccount.CreateSubAccount(collect);

```


#### <a name="create_suspend_sub_account"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SubAccountController.CreateSuspendSubAccount") CreateSuspendSubAccount

> Suspend or unsuspend


```csharp
Task<string> CreateSuspendSubAccount(CreateSuspendSubAccountInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subAccountSID |  ``` Required ```  | The SubaccountSid to be activated or suspended |
| activate |  ``` Required ```  ``` DefaultValue ```  | 0 to suspend or 1 to activate |
| responseType |  ``` Optional ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
CreateSuspendSubAccountInput collect = new CreateSuspendSubAccountInput();

string subAccountSID = "SubAccountSID";
collect.SubAccountSID = subAccountSID;

var activate = (Models.ActivateStatus)0;
collect.Activate = activate;

string responseType = "ResponseType";
collect.ResponseType = responseType;


string result = await subAccount.CreateSuspendSubAccount(collect);

```


#### <a name="create_delete_sub_account"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SubAccountController.CreateDeleteSubAccount") CreateDeleteSubAccount

> Delete sub account or merge numbers into parent


```csharp
Task<string> CreateDeleteSubAccount(CreateDeleteSubAccountInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subAccountSID |  ``` Required ```  | The SubaccountSid to be deleted |
| mergeNumber |  ``` Required ```  ``` DefaultValue ```  | 0 to delete or 1 to merge numbers to parent account. |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateDeleteSubAccountInput collect = new CreateDeleteSubAccountInput();

string subAccountSID = "SubAccountSID";
collect.SubAccountSID = subAccountSID;

var mergeNumber = (Models.MergeNumberStatus)0;
collect.MergeNumber = mergeNumber;

string responseType = "json";
collect.ResponseType = responseType;


string result = await subAccount.CreateDeleteSubAccount(collect);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="address_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.AddressController") AddressController

#### Get singleton instance

The singleton instance of the ``` AddressController ``` class can be accessed from the API Client.

```csharp
AddressController address = client.Address;
```

#### <a name="create_address"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.AddressController.CreateAddress") CreateAddress

> To add an address to your address book, you create a new address object. You can retrieve and delete individual addresses as well as get a list of addresses. Addresses are identified by a unique random ID.


```csharp
Task<string> CreateAddress(CreateAddressInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| name |  ``` Required ```  | Name of user |
| address |  ``` Required ```  | Address of user. |
| country |  ``` Required ```  | Must be a 2 letter country short-name code (ISO 3166) |
| state |  ``` Required ```  | Must be a 2 letter State eg. CA for US. For Some Countries it can be greater than 2 letters. |
| city |  ``` Required ```  | City Name. |
| zip |  ``` Required ```  | Zip code of city. |
| description |  ``` Optional ```  | Description of addresses. |
| email |  ``` Optional ```  | Email Id of user. |
| phone |  ``` Optional ```  | Phone number of user. |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type either json or xml |


#### Example Usage

```csharp
CreateAddressInput collect = new CreateAddressInput();

string name = "Name";
collect.Name = name;

string address = "Address";
collect.Address = address;

string country = "Country";
collect.Country = country;

string state = "State";
collect.State = state;

string city = "City";
collect.City = city;

string zip = "Zip";
collect.Zip = zip;

string description = "Description";
collect.Description = description;

string email = "email";
collect.Email = email;

string phone = "Phone";
collect.Phone = phone;

string responseType = "json";
collect.ResponseType = responseType;


string result = await address.CreateAddress(collect);

```


#### <a name="create_delete_address"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.AddressController.CreateDeleteAddress") CreateDeleteAddress

> To delete Address to your address book


```csharp
Task<string> CreateDeleteAddress(CreateDeleteAddressInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| addressSID |  ``` Required ```  | The identifier of the address to be deleted. |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type either json or xml |


#### Example Usage

```csharp
CreateDeleteAddressInput collect = new CreateDeleteAddressInput();

string addressSID = "AddressSID";
collect.AddressSID = addressSID;

string responseType = "json";
collect.ResponseType = responseType;


string result = await address.CreateDeleteAddress(collect);

```


#### <a name="create_verify_address"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.AddressController.CreateVerifyAddress") CreateVerifyAddress

> Validates an address given.


```csharp
Task<string> CreateVerifyAddress(CreateVerifyAddressInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| addressSID |  ``` Required ```  | The identifier of the address to be verified. |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type either json or xml |


#### Example Usage

```csharp
CreateVerifyAddressInput collect = new CreateVerifyAddressInput();

string addressSID = "AddressSID";
collect.AddressSID = addressSID;

string responseType = "json";
collect.ResponseType = responseType;


string result = await address.CreateVerifyAddress(collect);

```


#### <a name="create_list_address"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.AddressController.CreateListAddress") CreateListAddress

> List All Address 


```csharp
Task<string> CreateListAddress(CreateListAddressInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  ``` DefaultValue ```  | Return requested # of items starting the value, default=0, must be an integer |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | How many results to return, default is 10, max is 100, must be an integer |
| addressSID |  ``` Optional ```  | addresses Sid |
| dateCreated |  ``` Optional ```  | date created address. |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response Type either json or xml |


#### Example Usage

```csharp
CreateListAddressInput collect = new CreateListAddressInput();

int? page = 1;
collect.Page = page;

int? pageSize = 10;
collect.PageSize = pageSize;

string addressSID = "AddressSID";
collect.AddressSID = addressSID;

string dateCreated = "DateCreated";
collect.DateCreated = dateCreated;

string responseType = "json";
collect.ResponseType = responseType;


string result = await address.CreateListAddress(collect);

```


#### <a name="create_view_address"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.AddressController.CreateViewAddress") CreateViewAddress

> View Address Specific address Book by providing the address id


```csharp
Task<string> CreateViewAddress(CreateViewAddressInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| addressSID |  ``` Required ```  | The identifier of the address to be retrieved. |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response Type either json or xml |


#### Example Usage

```csharp
CreateViewAddressInput collect = new CreateViewAddressInput();

string addressSID = "AddressSID";
collect.AddressSID = addressSID;

string responseType = "json";
collect.ResponseType = responseType;


string result = await address.CreateViewAddress(collect);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="phone_number_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.PhoneNumberController") PhoneNumberController

#### Get singleton instance

The singleton instance of the ``` PhoneNumberController ``` class can be accessed from the API Client.

```csharp
PhoneNumberController phoneNumber = client.PhoneNumber;
```

#### <a name="update_phone_number"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.PhoneNumberController.UpdatePhoneNumber") UpdatePhoneNumber

> Update Phone Number Details


```csharp
Task<string> UpdatePhoneNumber(UpdatePhoneNumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | TODO: Add a parameter description |
| friendlyName |  ``` Optional ```  | TODO: Add a parameter description |
| voiceUrl |  ``` Optional ```  | URL requested once the call connects |
| voiceMethod |  ``` Optional ```  | TODO: Add a parameter description |
| voiceFallbackUrl |  ``` Optional ```  | URL requested if the voice URL is not available |
| voiceFallbackMethod |  ``` Optional ```  | TODO: Add a parameter description |
| hangupCallback |  ``` Optional ```  | TODO: Add a parameter description |
| hangupCallbackMethod |  ``` Optional ```  | TODO: Add a parameter description |
| heartbeatUrl |  ``` Optional ```  | URL requested once the call connects |
| heartbeatMethod |  ``` Optional ```  | URL that can be requested every 60 seconds during the call to notify of elapsed time |
| smsUrl |  ``` Optional ```  | URL requested when an SMS is received |
| smsMethod |  ``` Optional ```  | TODO: Add a parameter description |
| smsFallbackUrl |  ``` Optional ```  | URL requested once the call connects |
| smsFallbackMethod |  ``` Optional ```  | URL requested if the sms URL is not available |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
UpdatePhoneNumberInput collect = new UpdatePhoneNumberInput();

string phoneNumber = "PhoneNumber";
collect.PhoneNumber = phoneNumber;

string friendlyName = "FriendlyName";
collect.FriendlyName = friendlyName;

string voiceUrl = "VoiceUrl";
collect.VoiceUrl = voiceUrl;

var voiceMethod = Models.HttpAction?Helper.ParseString("GET");
collect.VoiceMethod = voiceMethod;

string voiceFallbackUrl = "VoiceFallbackUrl";
collect.VoiceFallbackUrl = voiceFallbackUrl;

var voiceFallbackMethod = Models.HttpAction?Helper.ParseString("GET");
collect.VoiceFallbackMethod = voiceFallbackMethod;

string hangupCallback = "HangupCallback";
collect.HangupCallback = hangupCallback;

var hangupCallbackMethod = Models.HttpAction?Helper.ParseString("GET");
collect.HangupCallbackMethod = hangupCallbackMethod;

string heartbeatUrl = "HeartbeatUrl";
collect.HeartbeatUrl = heartbeatUrl;

var heartbeatMethod = Models.HttpAction?Helper.ParseString("GET");
collect.HeartbeatMethod = heartbeatMethod;

string smsUrl = "SmsUrl";
collect.SmsUrl = smsUrl;

var smsMethod = Models.HttpAction?Helper.ParseString("GET");
collect.SmsMethod = smsMethod;

string smsFallbackUrl = "SmsFallbackUrl";
collect.SmsFallbackUrl = smsFallbackUrl;

var smsFallbackMethod = Models.HttpAction?Helper.ParseString("GET");
collect.SmsFallbackMethod = smsFallbackMethod;

string responseType = "json";
collect.ResponseType = responseType;


string result = await phoneNumber.UpdatePhoneNumber(collect);

```


#### <a name="create_buy_number"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.PhoneNumberController.CreateBuyNumber") CreateBuyNumber

> Buy Phone Number 


```csharp
Task<string> CreateBuyNumber(CreateBuyNumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | Phone number to be purchase |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateBuyNumberInput collect = new CreateBuyNumberInput();

string phoneNumber = "PhoneNumber";
collect.PhoneNumber = phoneNumber;

string responseType = "json";
collect.ResponseType = responseType;


string result = await phoneNumber.CreateBuyNumber(collect);

```


#### <a name="create_release_number"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.PhoneNumberController.CreateReleaseNumber") CreateReleaseNumber

> Release number from account


```csharp
Task<string> CreateReleaseNumber(CreateReleaseNumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | Phone number to be relase |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateReleaseNumberInput collect = new CreateReleaseNumberInput();

string phoneNumber = "PhoneNumber";
collect.PhoneNumber = phoneNumber;

string responseType = "json";
collect.ResponseType = responseType;


string result = await phoneNumber.CreateReleaseNumber(collect);

```


#### <a name="create_view_number_details"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.PhoneNumberController.CreateViewNumberDetails") CreateViewNumberDetails

> Get Phone Number Details


```csharp
Task<string> CreateViewNumberDetails(CreateViewNumberDetailsInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| phoneNumber |  ``` Required ```  | Get Phone number Detail |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateViewNumberDetailsInput collect = new CreateViewNumberDetailsInput();

string phoneNumber = "PhoneNumber";
collect.PhoneNumber = phoneNumber;

string responseType = "json";
collect.ResponseType = responseType;


string result = await phoneNumber.CreateViewNumberDetails(collect);

```


#### <a name="create_list_number"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.PhoneNumberController.CreateListNumber") CreateListNumber

> List Account's Phone number details


```csharp
Task<string> CreateListNumber(CreateListNumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Which page of the overall response will be returned. Zero indexed |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | Number of individual resources listed in the response per page |
| numberType |  ``` Optional ```  | TODO: Add a parameter description |
| friendlyName |  ``` Optional ```  | TODO: Add a parameter description |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateListNumberInput collect = new CreateListNumberInput();

int? page = 32;
collect.Page = page;

int? pageSize = 10;
collect.PageSize = pageSize;

var numberType = Models.NumberType?Helper.ParseString("ALL");
collect.NumberType = numberType;

string friendlyName = "FriendlyName";
collect.FriendlyName = friendlyName;

string responseType = "json";
collect.ResponseType = responseType;


string result = await phoneNumber.CreateListNumber(collect);

```


#### <a name="create_available_phone_number"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.PhoneNumberController.CreateAvailablePhoneNumber") CreateAvailablePhoneNumber

> Available Phone Number


```csharp
Task<string> CreateAvailablePhoneNumber(CreateAvailablePhoneNumberInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| numberType |  ``` Required ```  | Number type either SMS,Voice or all |
| areaCode |  ``` Required ```  | Phone Number Area Code |
| pageSize |  ``` Optional ```  ``` DefaultValue ```  | Page Size |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateAvailablePhoneNumberInput collect = new CreateAvailablePhoneNumberInput();

var numberType = Models.NumberTypeHelper.ParseString("ALL");
collect.NumberType = numberType;

string areaCode = "AreaCode";
collect.AreaCode = areaCode;

int? pageSize = 10;
collect.PageSize = pageSize;

string responseType = "json";
collect.ResponseType = responseType;


string result = await phoneNumber.CreateAvailablePhoneNumber(collect);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="recording_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.RecordingController") RecordingController

#### Get singleton instance

The singleton instance of the ``` RecordingController ``` class can be accessed from the API Client.

```csharp
RecordingController recording = client.Recording;
```

#### <a name="create_list_recording"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.RecordingController.CreateListRecording") CreateListRecording

> List out Recordings


```csharp
Task<string> CreateListRecording(CreateListRecordingInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Which page of the overall response will be returned. Zero indexed |
| pageSize |  ``` Optional ```  | Number of individual resources listed in the response per page |
| dateCreated |  ``` Optional ```  | TODO: Add a parameter description |
| callSid |  ``` Optional ```  | TODO: Add a parameter description |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateListRecordingInput collect = new CreateListRecordingInput();

int? page = 32;
collect.Page = page;

int? pageSize = 32;
collect.PageSize = pageSize;

string dateCreated = "DateCreated";
collect.DateCreated = dateCreated;

string callSid = "CallSid";
collect.CallSid = callSid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await recording.CreateListRecording(collect);

```


#### <a name="create_delete_recording"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.RecordingController.CreateDeleteRecording") CreateDeleteRecording

> Delete Recording Record


```csharp
Task<string> CreateDeleteRecording(CreateDeleteRecordingInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recordingSid |  ``` Required ```  | Unique Recording Sid to be delete |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateDeleteRecordingInput collect = new CreateDeleteRecordingInput();

string recordingSid = "RecordingSid";
collect.RecordingSid = recordingSid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await recording.CreateDeleteRecording(collect);

```


#### <a name="create_view_recording"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.RecordingController.CreateViewRecording") CreateViewRecording

> View a specific Recording


```csharp
Task<string> CreateViewRecording(CreateViewRecordingInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recordingSid |  ``` Required ```  | Search Recording sid |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateViewRecordingInput collect = new CreateViewRecordingInput();

string recordingSid = "RecordingSid";
collect.RecordingSid = recordingSid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await recording.CreateViewRecording(collect);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="sms_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.SMSController") SMSController

#### Get singleton instance

The singleton instance of the ``` SMSController ``` class can be accessed from the API Client.

```csharp
SMSController sMS = client.SMS;
```

#### <a name="create_list_inbound_sms"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SMSController.CreateListInboundSMS") CreateListInboundSMS

> List All Inbound SMS


```csharp
Task<string> CreateListInboundSMS(CreateListInboundSMSInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Which page of the overall response will be returned. Zero indexed |
| pagesize |  ``` Optional ```  | Number of individual resources listed in the response per page |
| mfrom |  ``` Optional ```  | From Number to Inbound SMS |
| to |  ``` Optional ```  | To Number to get Inbound SMS |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateListInboundSMSInput collect = new CreateListInboundSMSInput();

int? page = 32;
collect.Page = page;

string pagesize = "pagesize";
collect.Pagesize = pagesize;

string mfrom = "from";
collect.Mfrom = mfrom;

string to = "to";
collect.To = to;

string responseType = "json";
collect.ResponseType = responseType;


string result = await sMS.CreateListInboundSMS(collect);

```


#### <a name="create_list_sms"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SMSController.CreateListSMS") CreateListSMS

> List All SMS


```csharp
Task<string> CreateListSMS(CreateListSMSInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | Which page of the overall response will be returned. Zero indexed |
| pagesize |  ``` Optional ```  | Number of individual resources listed in the response per page |
| mfrom |  ``` Optional ```  | Messages sent from this number |
| to |  ``` Optional ```  | Messages sent to this number |
| datesent |  ``` Optional ```  | Only list SMS messages sent in the specified date range |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateListSMSInput collect = new CreateListSMSInput();

int? page = 32;
collect.Page = page;

int? pagesize = 32;
collect.Pagesize = pagesize;

string mfrom = "from";
collect.Mfrom = mfrom;

string to = "to";
collect.To = to;

string datesent = "datesent";
collect.Datesent = datesent;

string responseType = "json";
collect.ResponseType = responseType;


string result = await sMS.CreateListSMS(collect);

```


#### <a name="create_send_sms"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SMSController.CreateSendSMS") CreateSendSMS

> Send an SMS from a message360 number


```csharp
Task<string> CreateSendSMS(CreateSendSMSInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| fromcountrycode |  ``` Required ```  ``` DefaultValue ```  | From Country Code |
| mfrom |  ``` Required ```  | SMS enabled Message360 number to send this message from |
| tocountrycode |  ``` Required ```  ``` DefaultValue ```  | To country code |
| to |  ``` Required ```  | Number to send the SMS to |
| body |  ``` Required ```  | Text Message To Send |
| method |  ``` Optional ```  | Specifies the HTTP method used to request the required URL once SMS sent. |
| messagestatuscallback |  ``` Optional ```  | URL that can be requested to receive notification when SMS has Sent. A set of default parameters will be sent here once the SMS is finished. |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateSendSMSInput collect = new CreateSendSMSInput();

int fromcountrycode = 1;
collect.Fromcountrycode = fromcountrycode;

string mfrom = "from";
collect.Mfrom = mfrom;

int tocountrycode = 1;
collect.Tocountrycode = tocountrycode;

string to = "to";
collect.To = to;

string body = "body";
collect.Body = body;

var method = Models.HttpAction?Helper.ParseString("GET");
collect.Method = method;

string messagestatuscallback = "messagestatuscallback";
collect.Messagestatuscallback = messagestatuscallback;

string responseType = "json";
collect.ResponseType = responseType;


string result = await sMS.CreateSendSMS(collect);

```


#### <a name="create_view_sms"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.SMSController.CreateViewSMS") CreateViewSMS

> View a Particular SMS


```csharp
Task<string> CreateViewSMS(CreateViewSMSInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| messagesid |  ``` Required ```  | Message sid |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateViewSMSInput collect = new CreateViewSMSInput();

string messagesid = "messagesid";
collect.Messagesid = messagesid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await sMS.CreateViewSMS(collect);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="transcription_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.TranscriptionController") TranscriptionController

#### Get singleton instance

The singleton instance of the ``` TranscriptionController ``` class can be accessed from the API Client.

```csharp
TranscriptionController transcription = client.Transcription;
```

#### <a name="create_audio_url_transcription"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.TranscriptionController.CreateAudioURLTranscription") CreateAudioURLTranscription

> Audio URL Transcriptions


```csharp
Task<string> CreateAudioURLTranscription(CreateAudioURLTranscriptionInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| audioUrl |  ``` Required ```  | Audio url |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateAudioURLTranscriptionInput collect = new CreateAudioURLTranscriptionInput();

string audioUrl = "AudioUrl";
collect.AudioUrl = audioUrl;

string responseType = "json";
collect.ResponseType = responseType;


string result = await transcription.CreateAudioURLTranscription(collect);

```


#### <a name="create_recording_transcription"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.TranscriptionController.CreateRecordingTranscription") CreateRecordingTranscription

> Recording Transcriptions


```csharp
Task<string> CreateRecordingTranscription(CreateRecordingTranscriptionInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| recordingSid |  ``` Required ```  | Unique Recording sid |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateRecordingTranscriptionInput collect = new CreateRecordingTranscriptionInput();

string recordingSid = "RecordingSid";
collect.RecordingSid = recordingSid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await transcription.CreateRecordingTranscription(collect);

```


#### <a name="create_view_transcription"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.TranscriptionController.CreateViewTranscription") CreateViewTranscription

> View Specific Transcriptions


```csharp
Task<string> CreateViewTranscription(CreateViewTranscriptionInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| transcriptionSid |  ``` Required ```  | Unique Transcription ID |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateViewTranscriptionInput collect = new CreateViewTranscriptionInput();

string transcriptionSid = "TranscriptionSid";
collect.TranscriptionSid = transcriptionSid;

string responseType = "json";
collect.ResponseType = responseType;


string result = await transcription.CreateViewTranscription(collect);

```


#### <a name="create_list_transcription"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.TranscriptionController.CreateListTranscription") CreateListTranscription

> Get All transcriptions


```csharp
Task<string> CreateListTranscription(CreateListTranscriptionInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | TODO: Add a parameter description |
| pageSize |  ``` Optional ```  | TODO: Add a parameter description |
| status |  ``` Optional ```  | TODO: Add a parameter description |
| dateTranscribed |  ``` Optional ```  | TODO: Add a parameter description |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateListTranscriptionInput collect = new CreateListTranscriptionInput();

int? page = 124;
collect.Page = page;

int? pageSize = 124;
collect.PageSize = pageSize;

var status = Models.Status?Helper.ParseString("INPROGRESS");
collect.Status = status;

string dateTranscribed = "DateTranscribed";
collect.DateTranscribed = dateTranscribed;

string responseType = "json";
collect.ResponseType = responseType;


string result = await transcription.CreateListTranscription(collect);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="usage_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.UsageController") UsageController

#### Get singleton instance

The singleton instance of the ``` UsageController ``` class can be accessed from the API Client.

```csharp
UsageController usage = client.Usage;
```

#### <a name="create_list_usage"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.UsageController.CreateListUsage") CreateListUsage

> Get all usage 


```csharp
Task<string> CreateListUsage(CreateListUsageInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| productCode |  ``` Required ```  ``` DefaultValue ```  | Product Code |
| startDate |  ``` Required ```  ``` DefaultValue ```  | Start Usage Date |
| endDate |  ``` Required ```  ``` DefaultValue ```  | End Usage Date |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateListUsageInput collect = new CreateListUsageInput();

var productCode = (Models.ProductCode)0;
collect.ProductCode = productCode;

string startDate = "2016-09-06";
collect.StartDate = startDate;

string endDate = "2016-09-06";
collect.EndDate = endDate;

string responseType = "json";
collect.ResponseType = responseType;


string result = await usage.CreateListUsage(collect);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="account_controller"></a>![Class: ](https://apidocs.io/img/class.png "message360.Controllers.AccountController") AccountController

#### Get singleton instance

The singleton instance of the ``` AccountController ``` class can be accessed from the API Client.

```csharp
AccountController account = client.Account;
```

#### <a name="create_view_account"></a>![Method: ](https://apidocs.io/img/method.png "message360.Controllers.AccountController.CreateViewAccount") CreateViewAccount

> Display Account Description


```csharp
Task<string> CreateViewAccount(CreateViewAccountInput input)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| date |  ``` Required ```  | TODO: Add a parameter description |
| responseType |  ``` Optional ```  ``` DefaultValue ```  | Response type format xml or json |


#### Example Usage

```csharp
CreateViewAccountInput collect = new CreateViewAccountInput();

string date = "Date";
collect.Date = date;

string responseType = "json";
collect.ResponseType = responseType;


string result = await account.CreateViewAccount(collect);

```


[Back to List of Controllers](#list_of_controllers)



