Feature: General Training Scenarions

    #As the user, I want to be able to fullfill the training scenarions available in the DemoQA page.

#Background: Access DemoQA
    #Given I enter the domain "https://demoqa.com/"
    #And I click the "Elements" button

@Text
Scenario: Text box interaction
    When I click Text Box in the Elements menu
    And I fill the various fields with:
    | FullName | Email | CurrentAdress | PermanentAdress |
    | Test Dummy | testdummy@gmail.com | Current Road, 124 | Permanent Road, 253 |
    And Press the Submit button
    #Then A box shows up at the bottom with the information:
    #| Name | Email | CurrentAdress | PermanentAdress |
    #| Test Dummy | testdummy@gmail.com | Current Road, 124 | Permanent Road, 253 |

#@Buttons
#Scenario: Standart button interaction
#    When I click the Buttons option in the Elements menu
#    And I click the buttons
#    Then They return a message
#
#    Examples:
#        | button | message |
#        | Double Click Me | You have done a double click |
#        | Right Click Me | You have done a right click |
#        | Click Me | You have done a dynamic click |

#@Radio
#Scenario Outline: Radio button interaction
#    When I click Radio Button in the Elements menu
#    And I select the one of the options
#    Then I recieve a message
#
#    Examples:
#        | option | message |
#        | Yes | You have selected Yes |
#        | Impressive | You have selected Impressive |

#Scenario Outline: Check box interaction
#    When I click "Check Box" in the "Elements" menu
#    And I click the Arrow to open the folder list
#    And I select the folder "<folder>"
#    Then I recieve a message reading: "You have selected: <folder> <children>"
#    And The folder checkbox and the children checkboxes get selected
#
#    Examples:
#        | folder | children |
#        | Desktop | Notes, Commands |
#        | Documents | WorkSpace, Office |
#        | WorkSpace | React, Angular, Vue |
#        | Office | Public, Private, Classified, General |
#        | Downloads | Word File.doc, Excel File.doc |
#

