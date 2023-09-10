# CSNetAPI
CSNetAPI is a simple .NET 7.0 API that provides greetings through two distinct endpoints.

## Deployment
The API is deployed on Render and is accessible at https://csnetapi.onrender.com.

## Endpoints
### Codestream Endpoint

URL: https://csnetapi.onrender.com/Codestream  
Method: GET  
Response: "Hello, Codestreamers!"  
Let's Go Endpoint  

### Let's Go! EnpointN
URL: https://csnetapi.onrender.com/LetsGo  
Method: GET  
Response: "Let's go! Let's build an API!"  
Controllers  
The API has two controllers:  

## Controllers
The API has two controllers:  

CodestreamController: Returns greetings to Codestreamers.  
LetsGoController: Motivates users to build an API.  

## Setup and Run Locally
Prerequisites  
.NET SDK 7.0  
Docker (Optional)  
Steps  
Clone the repository  

bash  
Copy code  
git clone https://github.com/anpythomas/CSNetAPI.git  
cd CSNetAPI  
To run the application, use the following command:  

bash  
Copy code  
dotnet run  
If you're using Docker, you can build and run the application in a Docker container:  

bash  
Copy code  
docker build -t csnetapi .  
docker run -p 8080:80 csnetapi  
Once running, navigate to http://localhost:8080/Codestream or http://localhost:8080/LetsGo to test the endpoints.  

```
HelloWorldAPI
├─ Controllers
│  ├─ CodestreamController.cs
│  └─ LetsGoController.cs
├─ Dockerfile
├─ HelloWorldAPI.csproj
├─ HelloWorldAPI.sln
├─ Program.cs
├─ Properties
│  └─ launchSettings.json
├─ README.md
├─ appsettings.Development.json
├─ appsettings.json
├─ bin
│  └─ Debug
│     ├─ net5.0
│     └─ net7.0
└─ obj
   ├─ Debug
   │  ├─ net5.0
   │  │  ├─ .NETCoreApp,Version=v5.0.AssemblyAttributes.cs
   │  │  ├─ HelloWorldAPI.AssemblyInfo.cs
   │  │  ├─ HelloWorldAPI.AssemblyInfoInputs.cache
   │  │  ├─ HelloWorldAPI.GeneratedMSBuildEditorConfig.editorconfig
   │  │  ├─ HelloWorldAPI.GlobalUsings.g.cs
   │  │  ├─ HelloWorldAPI.assets.cache
   │  │  ├─ HelloWorldAPI.csproj.AssemblyReference.cache
   │  │  ├─ ref
   │  │  └─ refint
   │  └─ net7.0
   │     ├─ .NETCoreApp,Version=v7.0.AssemblyAttributes.cs
   │     ├─ HelloWorldAPI.AssemblyInfo.cs
   │     ├─ HelloWorldAPI.AssemblyInfoInputs.cache
   │     ├─ HelloWorldAPI.GeneratedMSBuildEditorConfig.editorconfig
   │     ├─ HelloWorldAPI.GlobalUsings.g.cs
   │     ├─ HelloWorldAPI.assets.cache
   │     ├─ HelloWorldAPI.csproj.AssemblyReference.cache
   │     ├─ ref
   │     ├─ refint
   │     └─ staticwebassets
   ├─ HelloWorldAPI.csproj.nuget.dgspec.json
   ├─ HelloWorldAPI.csproj.nuget.g.props
   ├─ HelloWorldAPI.csproj.nuget.g.targets
   ├─ project.assets.json
   └─ project.nuget.cache

```