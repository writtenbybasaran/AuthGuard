# Welcome to AuthGuard!

Auth guard is  simple, secure and maintainable api. Auth guard have Identity server and .net Core 5.

# Lifecycle

AuthGuard uses **Client Credential Flow** via identity server. In order to send a request to Api, you must first get tokens.
Request process is follow :

![Process](https://gcdnb.pbrd.co/images/HtNYDUVIRQ5g.jpg?o=1)

OpenId configuration url: {identityapp-url}/.well-known/openid-configuration

Token endpoint : {identityapp-url}/connect/token

Sample Identity req : 
```bash
curl --location --request POST '{identityapp-url}/connect/token' \
--header 'Content-Type: application/x-www-form-urlencoded' \
--data-urlencode 'client_id={IdentityConfig}' \
--data-urlencode 'client_secret={IdentityConfig}' \
--data-urlencode 'grant_type=client_credentials' \
--data-urlencode 'scope={IdentityConfig}'
```

Swagger AuthGuard : 
```bash
{AuthGuardapp-url}/swagger/index.html
```

## Validation
 All requests are filtered through Fluent validaton and cannot enter the system if they are not valid.
 
## Loging
All requests are logged to the console with serilog. Console is selected as sink, elk etc. can be updated.

## ExceptionHandling
In case of any error in the system, the exception handling middleware comes into play and logical responses are returned to the user.

## AutoMapper
Automapper is used for object swaps.

## Authorization
Added JWT based auth for Authorization. Requests can be sent to authorized services with bearer jwt. Otherwise it will return 401.
