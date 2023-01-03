alter trigger CalisanTrigger
on Calisanlars
after insert as begin
declare @DepartmanId int
declare @CalisanId int
select @CalisanId=CalisanID,@DepartmanId=DepartmanId from inserted
update Departmanlars set ToplamCalisan=ToplamCalisan+1 where DepartmanId=@DepartmanId
end