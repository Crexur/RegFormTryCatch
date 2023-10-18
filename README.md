# RegFormTryCatch

Documentation: frmRegistration Class
Properties:
StudentNumber(string studNum): Parses and returns the student number as a long data type. 
It performs error handling for invalid student number formats and large values.

ContactNo(string Contact): Parses and returns the contact number as a long data type. 
It validates the contact number format and performs error handling for invalid formats and large values.

FullName(string LastName, string FirstName, string MiddleInitial): 
Combines the last name, first name, and middle initial to form the full name in the format "Last Name, First Name, Middle Initial". 
It validates the name components and performs error handling for invalid formats.

Age(string age): Parses and returns the age as an int data type. 
It performs error handling for invalid age formats and large values.

Methods:
frmRegistration(): Initializes a new instance of the frmRegistration class.

btnregister_Click(object sender, EventArgs e): Event handler for the "Register" button click event. 
It gathers the user input, validates it using the property methods, and then proceeds with the registration process.
Any encountered exceptions are caught and displayed in a MessageBox.

Example Error Inputs:

Invalid student number format:
Student Number: "ABC123"
Error: "Invalid student number format."

Student number is too large:
Student Number: "9999999999999999999"
Error: "Student number is too large."

Invalid contact number format:
Contact Number: "123"
Error: "Invalid contact number format."

Contact number is too large:
Contact Number: "12345678901234567890"
Error: "Contact number is too large."

Invalid name format:
Last Name: "Smith123"
First Name: "John123"
Middle Initial: "Doe123"
Error: "Invalid name format."

Invalid age format:
Age: "twenty"
Error: "Invalid age format."
Age is too large:

Age: "9999"
Error: "Age is too large."
