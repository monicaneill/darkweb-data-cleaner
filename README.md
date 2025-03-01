# darkweb-data-cleaner
This Project was done in response to the tech task https://github.com/Boxphish/techtest-001/tree/main

This project processes fake compromised user data from a CSV file, transforms it to match a predefined schema, and exports the cleaned data into a new CSV file. 

I had started but failed to complete recovering the plaintext passwords using the rainbow table, but I managed to map the secret questions correctly. I had also initially started going down the path of
using database tables as I felt that would be better for scalability but was struggling to manage this so stuck with just handling csv reader directly which was much simpler. I believe if I'd gone
down this path this would have addressed Bonus Points 1. For Bonus Point 2, I can see that there is some corrupted data regarding the DOB. A method that handles/transforms date input to make sure
it is of the correct type/format would probably be all that would be needed to combat this

## Key Features
- Reads and parses the `users.csv` file.
- Maps user data to a new format (`BreachedDataUser`) in line with the new schema provided.
- Properly assigns secret questions and the corresponding answers to predefined slots.
- Randomly generates unique salt GUID for each user
- Exports collated transformed data to a new `breached_users.csv` file.

# Running project
- Clone repo and run the solution (ToDo - add release exe so don't need to run via IDE). You should see the location of your newly generated csv file path like so:
![image](https://github.com/user-attachments/assets/b221d02f-7629-43a8-bc1c-4fb845fa26b0)
- Locate the CSV, you will have an output like so:
![image](https://github.com/user-attachments/assets/47972c8e-438b-425c-a28f-0df95bf21994)

