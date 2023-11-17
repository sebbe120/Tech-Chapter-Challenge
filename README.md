# Tech Chapter apprentice coding challenge

#### _Read this before you start!_
_At Tech Chapter we receive a lot of applications for apprenticeship from allover the country. Allthough we are very excited about this, we have limited capacity in interviewing all applicants. Because of this we have decided to present all applicants with a coding challenge that will help os give a better insight in your current coding skills and to give all application similar conditions in our assessment._

_There is not a single solution for this challenge, and it is not a recuirement to complete all task. The idea is to give us a better understanding of your coding skills while you will get a better understanding of our expectations for your first time as apprentice at Tech chapter._

_The challege is created in the C#.NET coding language as this is widely used throughout the data technician education centres. If you prefer a different language please let us know at apprentice@techchapter.com_

_When you have finished challenge please archive and submit your solution to apprentice@techchapter.com along with your application, resume and any grade sheets you may have._

_Happy coding ;-)_

## Introduction to the tasks

In this repository you will find three tasks:
  1. Mario's Pizza
  2. Input validation
  3. Holiday Calendar

Common for all tasks you will find a number of Interface files within the `src/`-folder along with some stub Class implementations of the Interfaces. In the `tests/`-folder you will find some [NUnit](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit) test cases defined for the class implementations. Since the classes are currently stubbed the test cases will fail. Your job will be to change the class implementation to make the unittest cases pass. Once the testcase passes, the task is completed in accordence with [TDD](https://en.wikipedia.org/wiki/Test-driven_development#:~:text=Test%2Ddriven%20development%20(TDD),software%20against%20all%20test%20cases.) principles.
**Note:** you should NOT do any changes to the Interface files or the test case files, but you may change or add any class implementation as you see fit.

Below you will find user stories for all tasks.

## Mario's Pizza
#### Background
At Mario's Pizza customer many customers is having trouble on deciding from a long menu of pizzas. Mario whishes functionality to provide a customized menu for his customers based on their preferences.

#### Userstory
**AS A** pizza loving customer  
**I WANT** a method to filter the pizza menu based on ingridients  
**SO THAT** I can easily find my favorite pizza  

#### Accept criterias
**Scenario: Like ham, dislike pineapple**
**GIVEN** Must have ham  
**AND** Won't have pineapple  
**WHEN** finding pizzas  
**THEN** return Vesivio and Calzone  

## Input Validation
#### Background
On Tech Chapter's website we have a contact form, where visitors can submit their e-mail address. To avoid typos need input validation on the e-mail input field.

#### Userstory
**AS A** webmaster  
**I WANT** input validation on e-mail addresses  
**SO THAT** visitors can be alerted before submitting a mistyped address  

#### Accept criterias
**Scenario: No @**  
**GIVEN** No @ in e-mail  
**WHEN** validating email  
**THEN** return false  

**Scenario: No user**  
**GIVEN** e-mail string starting with `@` char  
**WHEN** validating email  
**THEN** return false  

**Scenario: No tld**  
**GIVEN** e-mail string without tld in hostname  
**WHEN** validating email  
**THEN** return false  

**Scenario: valid e-mail**  
**GIVEN** valid e-mail string  
**WHEN** validating email  
**THEN** return true  

## Holiday Calendar
#### Background
For the Tech Chapter timeregistration we need to notify employees if they forget to do their time registration. However, holidays are days off why they do not need to fill in their hours.  

**Hint:**
Holidays are a national mater not supported by the [GregorianCalendar](https://docs.microsoft.com/en-us/dotnet/api/system.globalization.gregoriancalendar) typically used for Calendar functionality within C#. Especially the easter can cause issues, since the days will vary from one year to the next based on the moon cycle. Also Maundy Thursday is a Holiday in Denmark but not in other countries like Sweden. Salling Group, that runs a large number of supermarkets has exposed an [API](https://developer.sallinggroup.com/api-reference#apis-holidays) of Danish holidays that may help you in succeeding this task. You will need to sign up for a token before you can start the integration.


#### Userstory 1
**AS A** bookkeeper  
**I WANT** a to know if a given day is a holiday  
**SO THAT** i know wether my colleagues must do time registration or not.  

#### Accept criteria
**Scenario: Holiday**  
**GIVEN** X-mas day: December 25th 2023
**WHEN** asking if holiday  
**THEN** return true  

**Scenario: Weekday**  
**GIVEN** regular weekday: April 21st 2023
**WHEN** asking if holiday  
**THEN** return false  

#### Userstory 2
**AS A** bookkeeper
**I WANT** a to know all holidays within a time period  
**SO THAT** I can tell my colleagues in advance  

**Scenario: Easter month**  
**GIVEN** month with easter: April 2023
**WHEN** asking for all holidays  
**THEN** return Danish national holidays: Maundy thursday, Good Friday, Easter Sunday & Easter Monday)  
