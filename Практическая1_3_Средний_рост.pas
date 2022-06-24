Program prakt1_3;
const k = 23;
var
  Sum, Sr : real;
  i,n : integer;
  R:array[1..k] of real;
  
  begin
    randomize;
    writeln('Введите кол-во студентов');
    readln(n);
    Sum := 0;
    for i:=1 to n do 
      begin
      R[i]:= random(50) + 150;
      writeln('Рост ', i, ' студента = ',R[i],'');
      
      Sum:=Sum + R[i];
      end;
      Sr := Sum / n;
      writeln('Средний рост ', n, ' студентов = ', Sr:2:2);
  end.
  