# DessertDecider
Dessert Decider

An ASP .NET Core 2.0 web app with a Bot interface that uses Cognitive Services to detect food items and identify desserts from pictures you upload, to be stored in a SQL Azure database.

Let the bot decide if you've had too much dessert by auto-calculating "dessert points", and ask the bot whether you should have any more dessert items! 

- Web/API: http://dessertweb.azurewebsites.net/
- Bot: http://dessertbot.azurewebsites.net/
- Cognitive Services (Vision API): http://aka.ms/TryVision
- Dessert sample pic: <a href="images/dessert.jpeg">Dessert</a>

Suggested phrases (for bot interaction):
- "Should I eat dessert?"
- "How many points do I have?" or "show me points"
- "What is my max?"

**Notes on Web App secrets/passwords:**

The file "appsettings.json" has a placeholder value for "DefaultConnection". During development, you should use ASP .NET App Secrets on your local machine. On Azure, you should use environment variables. You can also create defined connection strings.

*References:*

- App Secrets: https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?tabs=visual-studio
- Hosting/Config: https://docs.microsoft.com/en-us/aspnet/core/fundamentals/hosting?tabs=aspnetcore2x 
- Azure Web Config: https://docs.microsoft.com/en-us/azure/app-service/web-sites-configure


**Notes on Bot App secrets/passwords:**

The file "AppSettingsSecrets.config.txt" has placeholder values for your Bot Id, App Id and App Password. You should rename this to "AppSettingsSecrets.config" (without the .txt extension) and replace the placeholder values. 

*References:*
- Bot Registration: https://docs.microsoft.com/en-us/bot-framework/portal-register-bot

**Tutorials on ASP .NET Core 2.0:**

- Docs: https://docs.microsoft.com/en-us/aspnet/core/tutorials/
- MVA Beginner: https://mva.microsoft.com/en-us/training-courses/aspnet-core-beginner-18153 
- MVA Intermediate: https://mva.microsoft.com/en-us/training-courses/aspnet-core-intermediate-18154 
- MVA Advanced: https://mva.microsoft.com/en-us/training-courses/aspnet-core-advanced-18155 

**Tutorials on Bot Framework**

- Docs: https://docs.microsoft.com/en-us/bot-framework/bot-builder-overview-getstarted 
- Build 2017: https://channel9.msdn.com/Events/Build/2017/B8097
- MVA Bots with C#: https://aka.ms/mvabots-cs 
- MVA Bots with NodeJS: https://aka.ms/mvabots-js 

**Tutorials on Cognitive Services**

- Docs: https://docs.microsoft.com/en-us/azure/#pivot=products&panel=cognitive 
- Computer Vision API: https://docs.microsoft.com/en-us/azure/cognitive-services/computer-vision/