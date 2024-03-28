
## Blood Bank

**
The blood bank project was established in order to facilitate the blood bank system.
There are three entities on this site: 

 1. sicks
 2. donors
 3. donations

The site organizes the system of donations to the blood bank so that a patient who needs a donation is added to the system and a donation entity is opened for him.
The system will match a donor to a patient according to blood type and will display optional donations.
A patient who has recovered is deleted from the system as well as donors who contributed, or donations that were made.
The system also updates data such as donation status and the like.
Each entity has five **rutes**:

**Sicks:**

 - GET: https://localhost:7113/api/Sicks (Retrieving a list of sicks)
 - GET: https://localhost:7113/api/Sicks/2 (Sick retrieval by ID)
 - POST: https://localhost:7113/api/Sicks (Adding sick)
 - PUT: https://localhost:7113/api/Sicks/2 (Update sick details)
 - DELETE: https://localhost:7113/api/Sicks/2 (Delete sick)

 **Donors:**
 
 - GET: https://localhost:7113/api/Donors (Retrieving a list of donors)
 - GET: https://localhost:7113/api/Donors/2 (Donor retrieval by ID)
 - POST: https://localhost:7113/api/Donors (Adding donor)
 - PUT: https://localhost:7113/api/Donors/2 (Update donor details)
 - DELETE: https://localhost:7113/api/Donors/2 (Delete donor)

**Donations:**

 - GET: https://localhost:7113/api/Donations (Retrieving a list of donations)
 - GET: https://localhost:7113/api/Donations/2 (Donation retrieval by ID)
 - POST: https://localhost:7113/api/Donations (Adding donation)
 - PUT: https://localhost:7113/api/Donations/2 (Update donation details)
 - DELETE: https://localhost:7113/api/Donations/2 (Delete donation)
