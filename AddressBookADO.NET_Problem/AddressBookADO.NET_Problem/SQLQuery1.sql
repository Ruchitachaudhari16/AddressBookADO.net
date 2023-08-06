CREATE PROCEDURE SPAddingNewData(
@FirstName VARCHAR(30),
@LastName VARCHAR(30),
@Address VARCHAR(100),
@City VARCHAR(30),
@State VARCHAR(30),
@Zip INT,
@PhoneNumber BIGINT,
@Email VARCHAR(50))
AS BEGIN
INSERT INTO AddressBookDB(FirstName,LastName,Address,City,State,Zip,PhoneNumber,EmailID)
VALUES(@FirstName,@LastName,@Address,@City,@State,@Zip,@PhoneNumber,@Email)
END
SELECT * FROM AddressBookDB;