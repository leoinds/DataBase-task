Feature: PaintTest

@mytag
Scenario: Insert the picture
    Given open the Paint 
    When user uploads an image
    And clicks the Select all button
    And clicks the Cut button
    And сloses the paint
    And declines to change the results
    Then the original picture has not changed
