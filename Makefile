DOTNET=dotnet
REPORT=reportgenerator
homeworks := $(shell ls -d Homework[1-8]/*.sln)

setup: coverlet reportgenerator
	@echo "Setup environment"

coverlet:
	@echo "Install coverlet global"
	$(DOTNET) tool install --global coverlet.console

reportgenerator:
	@echo "Install reportgenerator global"
	$(DOTNET) tool install --global dotnet-reportgenerator-globaltool

test:
	for workdir in $(homeworks) ; do \
		cd `dirname $$workdir` ; \
		dotnet build; \
		dotnet test; \
		cd .. ; \
	done 
