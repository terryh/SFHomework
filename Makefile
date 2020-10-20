DOTNET=dotnet
REPORT=reportgenerator

setup: coverlet reportgenerator
	@echo "Setup environment"

coverlet:
	@echo "Install coverlet global"
	$(DOTNET) tool install --global coverlet.console


reportgenerator:
	@echo "Install reportgenerator global"
	$(DOTNET) tool install --global dotnet-reportgenerator-globaltool
