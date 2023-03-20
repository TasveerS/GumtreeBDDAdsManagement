# GumtreeBDDAdsManagement
A C# Test Automation Framework following a BDD approach for UI Testing of an Ads Management scenario for the Gumtree SA site- built with Selenium, Specflow and Allure reports.


The framework Utilizes Page Object Models with the POM Pattern , BDD steps and a Step definition file that binds the classes. There are uses of parameterized steps in BDD , datatables for test data and static varaiables for constants.
Additionally, the solution has a helper class for page scrolling and also the necessary configurations for allure reports.

Please note that a nuget restore is required to use this framework locally , this can be done by cloning the repo and right clicking the solution once opened up and selecting Restore Nuget Packages.
Allure reports has to be downloaded on your local machine - releases avaialable via https://github.com/allure-framework/allure2/releases , reports will then be generated once you are in the debug folder via CMD of the solution and simply enter "allure serve allure-results"


