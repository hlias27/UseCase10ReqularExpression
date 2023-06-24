# UseCase10ReqularExpression
The main function of this application is to compose regular expressions to search, match, or manipulate text within a string. You can validate the maximum string length or whether input contains at least one uppercase letter, lowercase letter, digit and special character from a predefined list: !"#$%&'()*+,-./:;<=>?@[\]^_`{|}~. It should return a match if the string is correct within the conditions or non-match if it is not. 

# Regular Expression implementation
Pattern for matching input string is based on look ahead positive assertion. The parts of pattern are:\
^                   - from the start of the input\
(?=^.{{5,{0}}}$)    - assert min and max length\
(?=.*[a-z])         - assert lowercase letter present\
(?=.*[A-Z])         - assert uppercase letter present\
(?=.*\d)            - assert digit present\
(?=.*[!""#$%&'()*+,-./:;<=>?@[\]^_`{{|}}~]) - assert predefined special characters\
\S+                 - then match one or more exclusively non whitespace characters\
$                   - end of the input

# Application Testing

This application is a console endless app. When app is run, you need to enter input data. You need to input value below message "Enter max length of input:" and press OK. If value is correct, you will see the message "Enter input string to validate:". Enter input string and press OK. The result of matching with pattern will be shown on the screen.
