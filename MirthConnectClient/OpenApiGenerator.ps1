cls
cd C:\Users\js90536\Downloads\Api
#wget https://server:8443/api/openapi.json openapi.json
#add 		
<#"securitySchemes": {
			"cookieAuth": {
				"type": "apiKey",
				"in": "cookie",
				"name": "JSESSIONID"
			}
		}
	},
	"security": [
		{
			"cookieAuth": []
		}
	]
to the componentssection 
and add "security": [] to the login method
#>
[System.Environment]::SetEnvironmentVariable('JAVA_OPTS','-Dio.swagger.parser.util.RemoteUrl.trustAll=true -Dio.swagger.v3.parser.util.RemoteUrl.trustAll=true') 
del -R -FOrce OpenapiGenerator.MirthConnect308
#md OpenapiGenerator.MirthConnect311 
#
java -jar ..\openapi-generator-cli.jar generate -g csharp-netcore -i mirth308.json -o OpenapiGenerator.MirthConnect308  -c config308.json --skip-validate-spec
del -R -FOrce OpenapiGenerator.MirthConnect308\docs
del -R -FOrce OpenapiGenerator.MirthConnect308\src
