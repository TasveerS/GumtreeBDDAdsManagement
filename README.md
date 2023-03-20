# GumtreeBDDAdsManagement
A C# Test Automation Framework following a BDD approach for UI Testing of an Ads Management scenario for the Gumtree SA site- built with Selenium, Specflow and Allure reports.

Each Page on the Gumtree site has a dedicated Page Object which houses it's Webelements and Methods. The framework Utilizes Page Object Models with the POM Pattern , BDD steps and a Step definition file that binds the classes. There are uses of parameterized steps in BDD to filter by a name in the dropdown, datatables for test data and static varaiables for constants such as website URL.Additionally, the solution has a helper and hook classes for page scrolling , Before/After scenarios and also the necessary configurations for allure reports to be generated.

Please note that a nuget restore is required to use this framework locally , this can be done by cloning the repo and right clicking the solution once opened up and selecting Restore Nuget Packages.
Allure reports has to be downloaded on your local machine - releases avaialable via https://github.com/allure-framework/allure2/releases , reports will then be generated once you are in the debug folder via CMD of the solution and simply enter "allure serve allure-results"


![image](https://user-images.githubusercontent.com/26908472/226321083-c7020c95-200c-419a-bbc2-69f06459add4.png)
![image](https://user-images.githubusercontent.com/26908472/226321184-978ae2a5-4ba0-45b3-9410-02e76bed5bdc.png)
