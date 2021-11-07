Feature: PaintTest

@mytag
Scenario: Insert the picture
    Given open the Paint 
    When user copies an image penguin.jpg
    And user inserts an image from the clipboard
    And user clicks Select all button
    And user clicks the Cut button
    And user сloses the paint
    And user declines to change the results
    Then the original picture penguin.jpg has not changed
