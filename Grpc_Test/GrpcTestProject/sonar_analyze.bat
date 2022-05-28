dotnet sonarscanner begin /k:"GrpcTest" /d:sonar.host.url="http://localhost:9000"  /d:sonar.login="54f4e1b05d92227c200a204ef12922b5a609548f"
dotnet build
dotnet sonarscanner end /d:sonar.login="54f4e1b05d92227c200a204ef12922b5a609548f"