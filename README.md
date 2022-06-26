## For Private Submission only

This Solution has 2 projects: **StudentsAPI** and **Student(Blazor)**

### Developed using
- VS 2022
- SQLServer Express
- .NET 6
- Not listing nuget packages here.

### StudentsAPI
+ Connection string can be found appsettings.json file of API project.
+ DB context configured to seed data on DB creation.
+ To setup database, please update DB server name.
+ Run **update-database** command from Package manager console. This setup database and seeds it with data.

### StudentsApp
+ **TriStateTest** page to show: bool? backed control.
+ **Students** page uses StudentAPI, to:
>> - List all students.
>> - View student details by clicking on details icon.
>> - View Student marks by clicking on trophy icon.
+ Solution file setup both projects as start-up.

#### Previews
![image](https://user-images.githubusercontent.com/2210826/175825978-7c8e67c1-4c9c-46a6-b1bd-9dac4472deff.png)
![image](https://user-images.githubusercontent.com/2210826/175825987-51e7dbad-d83d-4a54-a060-8134bf896e62.png)
![image](https://user-images.githubusercontent.com/2210826/175825969-8cb284b6-3aec-4c7b-9b59-9e2dc5ad4c7c.png)

![image](https://user-images.githubusercontent.com/2210826/175826038-80d8efb3-9c69-4ce7-a501-7d74b568a52e.png)
![image](https://user-images.githubusercontent.com/2210826/175826053-8f35f2e5-9e73-4bea-9f67-33979382106b.png)

![image](https://user-images.githubusercontent.com/2210826/175826080-3c19062a-0721-4dce-965c-23903bfe23ca.png)
![image](https://user-images.githubusercontent.com/2210826/175826090-b5ae3426-ec90-4737-afd7-a9699b0c813c.png)
![image](https://user-images.githubusercontent.com/2210826/175826113-7cca3f7c-e156-4607-b950-3dd90c7bf186.png)

