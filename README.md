# CSNetAPI
CSNetAPI is a simple .NET 7.0 API that provides greetings through two distinct endpoints.

## Deployment
The API is deployed on Render and is accessible at https://CSNetAPI.onrender.com.

## Endpoints
### Codestream Endpoint

URL: https://CSNetAPI.onrender.com/Codestream
Method: GET
Response: "Hello, Codestreamers!"
Let's Go Endpoint

### Let's Go! Enpoint
URL: https://CSNetAPI.onrender.com/LetsGo
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
