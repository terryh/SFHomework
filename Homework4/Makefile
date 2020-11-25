DOTNET=dotnet
REPORT=reportgenerator

build:
	@echo "Build project"
	$(DOTNET) build 

test:
	$(DOTNET) test -p:CollectCoverage=true -p:CoverletOutputFormat=cobertura -p:CoverletOutput=./.coverage.cobertura.xml

report: test
	$(REPORT) -reports:./Homework.Tests/.coverage.cobertura.xml -reporttypes:Html -targetdir:./.coverage
