Feature: AdManagement

  Scenario: Edit Gumtree Ad with Random Number
    Given I navigate to the Gumtree South Africa website
    When I have entered <Username> and <Password> on the login page
    And I navigate to "My Ads"
    Then I should see an ad present
    When I edit the ad
    And I append a 4 digit random number to the title
    And I post the ad
    Then I should see the title with the updated random number
    And I navigate to "Logout"
      Examples:
      | Username                      | Password   |
      | gumtreesaautomation@gmail.com | Gumtr33@SA |