Feature: Sending local currency
I want to send money in local currencies without making mistakes
    
@GettingPaid
Scenario: Successful Transfer
    Given I have a different local currency than my friend
    When I make a tranfer
    Then my friend should receive money in his local currency
 