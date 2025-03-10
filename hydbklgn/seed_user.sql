

begin tran
delete from CoreUser where id <>1 
insert CoreUser(UserId,post,UserName,EncPassword,tel,IsAdmin,IsReset,updatedAt,updatedBy,createdAt,level,email)
select post,post,UserName,EncPassword,Telephone,case when Admin = 'T' then 1 else 0 end,1,getdate(),'SYSTEM',getdate(),case when CE= 'T' then 6 when SE='T' then 9 else 18 end,email from  TWBBKDSHYD.dbo.accdata


