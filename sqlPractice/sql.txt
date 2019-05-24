sqlite> create table todolist (
   ...> id int,
   ...> description varchar(100),
   ...> daysUntilDue int,
   ...> status varchar(50));
sqlite> .headers on
sqlite> .mode column
sqlite> select * from todolist;
sqlite> insert into todolist (id, description, daysUntilDue, status) values(1, 'Dentist Appt', 5, 'incomplete');
sqlite> select * from todolist;
id          description   daysUntilDue  status
----------  ------------  ------------  ----------
1           Dentist Appt  5             incomplete
sqlite> insert into todolist (id, description, daysUntilDue, status) values(2, 'Music Camp', 7, 'incomplete');
sqlite> select * from todolist;
id          description   daysUntilDue  status
----------  ------------  ------------  ----------
1           Dentist Appt  5             incomplete
2           Music Camp    7             incomplete
sqlite> insert into todolist (id, description, daysUntilDue, status) values(3, 'Argentina vacation', 33, 'incomplete');
sqlite> select * from todolist;
id          description   daysUntilDue  status
----------  ------------  ------------  ----------
1           Dentist Appt  5             incomplete
2           Music Camp    7             incomplete
3           Argentina va  33            incomplete
sqlite> insert into todolist (id, description, daysUntilDue, status) values(4, 'Father's Day', 24, 'incomplete');
   ...> select * from todolist;
   ...> select * from todolist;
   ...> insert into todolist (id, description, daysUntilDue, status) values(5, 'Arlo's party', 16, 'incomplete');
Error: near "s": syntax error
sqlite> insert into todolist (id, description, daysUntilDue, status) values(5, 'Arlo party', 16, 'incomplete');
sqlite> select * from todolist;
id          description   daysUntilDue  status
----------  ------------  ------------  ----------
1           Dentist Appt  5             incomplete
2           Music Camp    7             incomplete
3           Argentina va  33            incomplete
5           Arlo party    16            incomplete
sqlite> insert into todolist (id, description, daysUntilDue, status) values(4, 'Father Day', 24, 'incomplete');
sqlite> select * from todolist;
id          description   daysUntilDue  status
----------  ------------  ------------  ----------
1           Dentist Appt  5             incomplete
2           Music Camp    7             incomplete
3           Argentina va  33            incomplete
5           Arlo party    16            incomplete
4           Father Day    24            incomplete
sqlite> delete from todolist where id = 5;
sqlite> select * from todolist;
id          description   daysUntilDue  status
----------  ------------  ------------  ----------
1           Dentist Appt  5             incomplete
2           Music Camp    7             incomplete
3           Argentina va  33            incomplete
4           Father Day    24            incomplete
sqlite> insert into todolist (id, description, daysUntilDue, status) values(5, 'Arlo party', 16, 'incomplete');
sqlite> select * from todolist;
id          description   daysUntilDue  status
----------  ------------  ------------  ----------
1           Dentist Appt  5             incomplete
2           Music Camp    7             incomplete
3           Argentina va  33            incomplete
4           Father Day    24            incomplete
5           Arlo party    16            incomplete
sqlite> update todolist
   ...> set description = 'Argentina'
   ...> where id = 3;
sqlite> select * from todolist;
id          description   daysUntilDue  status
----------  ------------  ------------  ----------
1           Dentist Appt  5             incomplete
2           Music Camp    7             incomplete
3           Argentina     33            incomplete
4           Father Day    24            incomplete
5           Arlo party    16            incomplete
sqlite> update todolist
   ...> set status = 'complete'
   ...> where id = 1;
sqlite> select * from todolist;
id          description   daysUntilDue  status
----------  ------------  ------------  ----------
1           Dentist Appt  5             complete
2           Music Camp    7             incomplete
3           Argentina     33            incomplete
4           Father Day    24            incomplete
5           Arlo party    16            incomplete
sqlite> update todolist
   ...> set daysUntilDue = 0
   ...> where id = 1;
sqlite> select * from todolist;
id          description   daysUntilDue  status
----------  ------------  ------------  ----------
1           Dentist Appt  0             complete
2           Music Camp    7             incomplete
3           Argentina     33            incomplete
4           Father Day    24            incomplete
5           Arlo party    16            incomplete
sqlite>