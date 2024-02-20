#Feature: General Training Scenarions
#
#    As the user, I want to be able to fullfill the Web Tables training scenario available in the DemoQA page.
#
#Background: Access Web Tables in the DemoQA page
#    Given I enter the domain "https://demoqa.com/"
#    And I click the "Elements" button
#    And I click "Web Tables" in the "Elements" dropdown
#
#Scenario Outline: Using the search bar
#    Given I click on the search bar
#    And Type what I want to search
#    Then The results get filtered if one of the fields "<fields>" matches what is searched
#
#    Examples:
#        | fields |
#        | First Name |
#        | Last Name |
#        | Age |
#        | Email |
#        | Salary |
#        | Department |
#
#Scenario: Adding a new record
#    Given I click on the "Add" button
#    And I fill the "Registration Form" fields correctly
#    And I click on the "Submit" button
#    Then A new record is added to the table
#
#Scenario: Deleting a record
#    Given I click on the trashcan icon of a record
#    Then That record is deleted from the table
#
#Scenario: Editing a record
#    Given I click on the pencil icon of a record
#    And I edit one of the fields of the "Registration Form"
#    And I click on the "Submit" button
#    Then The record gets changed accordingly
#
##Preciso fazer rows e Next/Previous buttons?