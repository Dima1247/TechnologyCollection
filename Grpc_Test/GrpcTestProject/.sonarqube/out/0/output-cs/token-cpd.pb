Ó.
RC:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcServer\Handlers\ServerHandler.cs
	namespace 	

GrpcServer
 
. 
Handlers 
{ 
public 
class	 
ServerHandler 
: 
IAsyncDisposable /
{0 1
private 
const 
int 
DEFAULT_SERVER_PORT )
=* +
$num, 1
;1 2
private 
const 
string 
DEFAULT_SERVER_HOST ,
=- .
$str/ :
;: ;
private 
readonly 
static 
ServerCredentials -&
DEFAULT_SERVER_CREDENTIALS. H
=I J
ServerCredentialsK \
.\ ]
Insecure] e
;e f
private 
Server 
_server 
; 
private 
ServerHandler 
( 
Server  
server! '
)' (
{) *
_server 
= 
server 
; 
} 
public!! 

Server!! 
Server!! 
=>!! 
_server!! #
;!!# $
public'' 

static'' 
ServerHandler'' #
GetDefaultServerHandler''  7
(''7 8
)''8 9
{'': ;
var(( 	 
reflectionServiceImp((
 
=((  
new((! $!
ReflectionServiceImpl((% :
(((: ;
GreetingService((; J
.((J K

Descriptor((K U
,((U V
ServerReflection((W g
.((g h

Descriptor((h r
)((r s
;((s t
Action** 
<** 
Server** 
.** '
ServiceDefinitionCollection** /
>**/ 0$
configureDefaultServices**1 I
=**J K
services**L T
=>**U W
{**X Y
services++ 
.++ 
Add++ 
(++ 
GreetingService++ $
.++$ %
BindService++% 0
(++0 1
new++1 4
GreetingServiceImp++5 G
(++G H
)++H I
)++I J
)++J K
;++K L
services,, 
.,, 
Add,, 
(,, 
ServerReflection,, %
.,,% &
BindService,,& 1
(,,1 2 
reflectionServiceImp,,2 F
),,F G
),,G H
;,,H I
services-- 
.-- 
Add-- 
(-- 
CalculatorService-- &
.--& '
BindService--' 2
(--2 3
new--3 6 
CalculatorServiceImp--7 K
(--K L
)--L M
)--M N
)--N O
;--O P
services.. 
... 
Add.. 
(.. 
SqrtService..  
...  !
BindService..! ,
(.., -
new..- 0
SqrtServiceImp..1 ?
(..? @
)..@ A
)..A B
)..B C
;..C D
}// 
;// 
Action11 
<11 
Server11 
.11  
ServerPortCollection11 (
>11( )!
configureDefaultPorts11* ?
=11@ A
ports11B G
=>11H J
{11K L
ports22 
.22 
Add22 
(22 
new22 

ServerPort22  
(22  !
DEFAULT_SERVER_HOST22! 4
,224 5
DEFAULT_SERVER_PORT226 I
,22I J&
DEFAULT_SERVER_CREDENTIALS22K e
)22e f
)22f g
;22g h
}33 
;33 
return55 
GetServerHandler55 
(55 $
configureDefaultServices55 6
,556 7!
configureDefaultPorts558 M
)55M N
;55N O
}66 
public88 

static88 
ServerHandler88 
GetServerHandler88  0
(880 1
Action881 7
<887 8
Server888 >
.88> ?'
ServiceDefinitionCollection88? Z
>88Z [
configureServices88\ m
,88m n
Action88o u
<88u v
Server88v |
.88| }!
ServerPortCollection	88} ë
>
88ë í
configurePorts
88ì °
)
88° ¢
{
88£ §
var99 	
server99
 
=99 
new99 
Server99 
(99 
)99 
;99  
configurePorts:: 
(:: 
server:: 
.:: 
Ports:: !
)::! "
;::" #
configureServices;; 
(;; 
server;; 
.;; 
Services;; '
);;' (
;;;( )
server<< 
.<< 
Start<< 
(<< 
)<< 
;<< 
return>> 
new>> 
ServerHandler>> 
(>> 
server>> %
)>>% &
;>>& '
}?? 
publicEE 

asyncEE 
	ValueTaskEE 
DisposeAsyncEE '
(EE' (
)EE( )
{EE* +
awaitFF 
DisposeAsyncCoreFF 
(FF 
)FF 
;FF 
GCGG 
.GG 	
SuppressFinalizeGG	 
(GG 
thisGG 
)GG 
;GG  
}HH 
	protectedJJ 
virtualJJ 
asyncJJ 
	ValueTaskJJ %
DisposeAsyncCoreJJ& 6
(JJ6 7
)JJ7 8
{JJ9 :
ifKK 
(KK	 

_serverKK
 
!=KK 
nullKK 
)KK 
{KK 
awaitLL  
ShutdownChannelAsyncLL "
(LL" #
)LL# $
;LL$ %
}MM 
_serverOO 
=OO 
nullOO 
;OO 
}PP 
privateRR 
TaskRR  
ShutdownChannelAsyncRR %
(RR% &
)RR& '
{RR( )
returnSS 
_serverSS 
.SS 
ShutdownAsyncSS "
(SS" #
)SS# $
;SS$ %
}TT 
}WW 
}XX ∞
CC:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcServer\Program.cs
	namespace 	

GrpcServer
 
{ 
public 
static	 
class 
Program 
{ 
private		 
static		 
async		 
Task		 
Main		 "
(		" #
)		# $
{		% &
try

 	
{


 
await 
using 
var 
serverHandler %
=& '
ServerHandler( 5
.5 6#
GetDefaultServerHandler6 M
(M N
)N O
;O P
var 

serverPort 
= 
serverHandler &
.& '
Server' -
.- .
Ports. 3
.3 4
FirstOrDefault4 B
(B C
)C D
;D E
Console 
. 
	WriteLine 
( 
$" 
$str @
{@ A

serverPortA K
.K L
PortL P
}P Q
"Q R
)R S
;S T
Console 
. 
ReadKey 
( 
) 
; 
} 
catch 
( 
IOException 
ioe 
) 
{ 
Console 
. 
	WriteLine 
( 
$" 
$str 9
{9 :
ioe: =
.= >
Message> E
}E F
"F G
)G H
;H I
} 
catch 
( 
	Exception 
ex 
) 
{ 
Console 
. 
	WriteLine 
( 
$" 
$str 3
{3 4
ex4 6
.6 7
Message7 >
}> ?
"? @
)@ A
;A B
} 
} 
} 
} ØG
YC:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcServer\Services\CalculatorServiceImp.cs
	namespace 	

GrpcServer
 
. 
Services 
{ 
public 
class	  
CalculatorServiceImp #
:$ %
CalculatorService& 7
.7 8!
CalculatorServiceBase8 M
{N O
public

 

override

 
Task

 
<

 
SumResponse

 $
>

$ %
CalculateSum

& 2
(

2 3

SumRequest

3 =
request

> E
,

E F
ServerCallContext

G X
context

Y `
)

` a
{

b c
return 
CalculateSumAsync 
( 
request &
.& '
FirstNumber' 2
,2 3
request4 ;
.; <
SecondNumber< H
)H I
;I J
} 
private 
Task 
< 
SumResponse 
> 
CalculateSumAsync /
(/ 0
int0 3
firstNumber4 ?
,? @
intA D
secondNumberE Q
)Q R
{S T
var 	
sum
 
= 
firstNumber 
+ 
secondNumber *
;* +
var 	
response
 
= 
new 
SumResponse $
{% &
Sum 
= 
sum 
} 
; 
return 
Task 
. 

FromResult 
( 
response %
)% &
;& '
} 
private 
IServerStreamWriter 
<  !
DecompositionResponse  5
>5 6(
_decompositionResponseStream7 S
;S T
public 

override 
Task "
CalculateDecomposition /
(/ 0 
DecompositionRequest0 D
requestE L
,L M
IServerStreamWriterN a
<a b!
DecompositionResponseb w
>w x
responseStream	y á
,
á à
ServerCallContext
â ö
context
õ ¢
)
¢ £
{
§ •(
_decompositionResponseStream "
=# $
responseStream% 3
;3 4
return   '
CalculateDecompositionAsync   (
(  ( )
request  ) 0
.  0 1
PrimeNumber  1 <
)  < =
;  = >
}!! 
private## 
async## 
Task## '
CalculateDecompositionAsync## 2
(##2 3
int##3 6
number##7 =
)##= >
{##? @
var$$ 	
divider$$
 
=$$ 
$num$$ 
;$$ 
while&& 
(&& 
number&& 
>&& 
$num&& 
)&& 
{&& 
if'' 

('' 
number'' 
%'' 
divider'' 
=='' 
$num''  !
)''! "
{''# $
await((
 %
WriteDividerToStreamAsync(( )
((() *
divider((* 1
)((1 2
;((2 3
number))
 
/=)) 
divider)) 
;)) 
}** 	
else++ 
{++ 
divider,,
 
++,, 
;,, 
}-- 	
}.. 
}// 
private11 
Task11 %
WriteDividerToStreamAsync11 *
(11* +
int11+ .
divider11/ 6
)116 7
{118 9
var22 	
result22
 
=22 
new22 !
DecompositionResponse22 ,
{22- .
Divider33 
=33 
divider33 
}44 
;44 
return66 (
_decompositionResponseStream66 )
.66) *

WriteAsync66* 4
(664 5
result665 ;
)66; <
;66< =
}77 
private== 
IAsyncStreamReader== 
<== 
AverageRequest== -
>==- .!
_averageRequestStream==/ D
;==D E
public?? 

override?? 
Task?? 
<?? 
AverageResponse?? (
>??( )
CalculateAverage??* :
(??: ;
IAsyncStreamReader??; M
<??M N
AverageRequest??N \
>??\ ]
requestStream??^ k
,??k l
ServerCallContext??m ~
context	?? Ü
)
??Ü á
{
??à â!
_averageRequestStream@@ 
=@@ 
requestStream@@ +
;@@+ ,
returnBB !
CalculateAverageAsyncBB "
(BB" #
)BB# $
;BB$ %
}CC 
privateEE 
asyncEE 
TaskEE 
<EE 
AverageResponseEE &
>EE& '!
CalculateAverageAsyncEE( =
(EE= >
)EE> ?
{EE@ A
varFF 	
sumFF
 
=FF 
$numFF 
;FF 
varGG 	
countGG
 
=GG 
$numGG 
;GG 
whileII 
(II 
awaitII !
_averageRequestStreamII (
.II( )
MoveNextII) 1
(II1 2
)II2 3
)II3 4
{II5 6
varJJ 
numberJJ 
=JJ !
_averageRequestStreamJJ *
.JJ* +
CurrentJJ+ 2
.JJ2 3
NumberJJ3 9
;JJ9 :
sumLL 
+=LL 
numberLL 
;LL 
countMM 
++MM 
;MM 
awaitOO #
WriteTextWithDelayAsyncOO %
(OO% &
$"OO& (
$strOO( 2
{OO2 3
numberOO3 9
}OO9 :
"OO: ;
)OO; <
;OO< =
}PP 
varRR 	
averageNumberRR
 
=RR 
sumRR 
/RR 
countRR  %
;RR% &
returnTT 
newTT 
AverageResponseTT  
{TT! "
AverageNumberUU 
=UU 
averageNumberUU %
}VV 
;VV 
}WW 
private]] 
IAsyncStreamReader]] 
<]] 
MaximumRequest]] -
>]]- .!
_maximumRequestStream]]/ D
;]]D E
private^^ 
IServerStreamWriter^^ 
<^^  
MaximumResponse^^  /
>^^/ 0"
_maximumResponseStream^^1 G
;^^G H
public`` 

override`` 
Task`` 
CalculateMaximumm`` *
(``* +
IAsyncStreamReader``+ =
<``= >
MaximumRequest``> L
>``L M
requestStream``N [
,``[ \
IServerStreamWriter``] p
<``p q
MaximumResponse	``q Ä
>
``Ä Å
responseStream
``Ç ê
,
``ê ë
ServerCallContext
``í £
context
``§ ´
)
``´ ¨
{
``≠ Æ!
_maximumRequestStreamaa 
=aa 
requestStreamaa +
;aa+ ,"
_maximumResponseStreambb 
=bb 
responseStreambb -
;bb- .
returndd !
CalculateMaximumAsyncdd "
(dd" #
)dd# $
;dd$ %
}ee 
privategg 
asyncgg 
Taskgg !
CalculateMaximumAsyncgg ,
(gg, -
)gg- .
{gg/ 0
varhh 	
maximumhh
 
=hh 
inthh 
.hh 
MinValuehh  
;hh  !
whilejj 
(jj 
awaitjj !
_maximumRequestStreamjj (
.jj( )
MoveNextjj) 1
(jj1 2
)jj2 3
)jj3 4
{jj5 6
varkk 
numberkk 
=kk !
_maximumRequestStreamkk *
.kk* +
Currentkk+ 2
.kk2 3
Numberkk3 9
;kk9 :
awaitll #
WriteTextWithDelayAsyncll %
(ll% &
$"ll& (
$strll( :
{ll: ;
numberll; A
}llA B
"llB C
)llC D
;llD E
ifnn 

(nn 
maximumnn 
>=nn 
numbernn 
)nn 
{nn  
continueoo
 
;oo 
}pp 	
maximumrr 
=rr 
numberrr 
;rr 
varss 
responsess 
=ss 
newss 
MaximumResponsess *
{ss+ ,
	MaxNumbertt
 
=tt 
maximumtt 
}uu 	
;uu	 

awaitww "
_maximumResponseStreamww $
.ww$ %

WriteAsyncww% /
(ww/ 0
responseww0 8
)ww8 9
;ww9 :
}xx 
}yy 
private 
Task #
WriteTextWithDelayAsync (
(( )
string) /
text0 4
)4 5
{6 7
Console
ÄÄ 
.
ÄÄ 
	WriteLine
ÄÄ 
(
ÄÄ 
text
ÄÄ 
)
ÄÄ 
;
ÄÄ 
return
ÅÅ 
Task
ÅÅ 
.
ÅÅ 
Delay
ÅÅ 
(
ÅÅ 
$num
ÅÅ 
)
ÅÅ 
;
ÅÅ 
}
ÇÇ 
}
ÖÖ 
}ÜÜ »K
WC:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcServer\Services\GreetingServiceImp.cs
	namespace		 	

GrpcServer		
 
.		 
Services		 
{		 
public

 
class

	 
GreetingServiceImp

 !
:

" #
GreetingServiceBase

$ 7
{

8 9
public 

override 
Task 
< 
GreetingResponse )
>) *
Greet+ 0
(0 1
GreetingRequest1 @
requestA H
,H I
ServerCallContextJ [
context\ c
)c d
{e f
return 

GreetAsync 
( 
request 
.  
Greeting  (
.( )
	FirstName) 2
,2 3
request4 ;
.; <
Greeting< D
.D E
LastNameE M
)M N
;N O
} 
private 
Task 
< 
GreetingResponse !
>! "

GreetAsync# -
(- .
string. 4
	firstName5 >
,> ?
string@ F
lastNameG O
)O P
{Q R
var 	
result
 
= 
$" 
$str 
{ 
	firstName %
}% &
$str& '
{' (
lastName( 0
}0 1
"1 2
;2 3
var 	
response
 
= 
new 
GreetingResponse )
{* +
Result 
= 
result 
} 
; 
return 
Task 
. 

FromResult 
( 
response %
)% &
;& '
} 
private 
IServerStreamWriter 
<  "
GreetManyTimesResponse  6
>6 7 
_greetResponseStream8 L
;L M
public   

override   
Task   
GreetManyTimes   '
(  ' (!
GreetManyTimesRequest  ( =
request  > E
,  E F
IServerStreamWriter  G Z
<  Z ["
GreetManyTimesResponse  [ q
>  q r
responseStream	  s Å
,
  Å Ç
ServerCallContext
  É î
context
  ï ú
)
  ú ù
{
  û ü 
_greetResponseStream!! 
=!! 
responseStream!! +
;!!+ ,
return## 
GreetManyTimesAsync##  
(##  !
request##! (
.##( )
Greeting##) 1
.##1 2
	FirstName##2 ;
,##; <
request##= D
.##D E
Greeting##E M
.##M N
LastName##N V
)##V W
;##W X
}$$ 
private&& 
async&& 
Task&& 
GreetManyTimesAsync&& *
(&&* +
string&&+ 1
	firstName&&2 ;
,&&; <
string&&= C
lastName&&D L
)&&L M
{&&N O
var'' 	
result''
 
='' 
$"'' 
$str'' 
{'' 
	firstName'' %
}''% &
$str''& '
{''' (
lastName''( 0
}''0 1
"''1 2
;''2 3
var(( 	
response((
 
=(( 
new(( "
GreetManyTimesResponse(( /
{((0 1
Result)) 
=)) 
result)) 
}** 
;** 
foreach,, 
(,, 
int,, 
_,, 
in,, 

Enumerable,, "
.,," #
Range,,# (
(,,( )
$num,,) *
,,,* +
$num,,, .
),,. /
),,/ 0
{,,1 2
await--  
_greetResponseStream-- "
.--" #

WriteAsync--# -
(--- .
response--. 6
)--6 7
;--7 8
}.. 
}// 
private55 
IAsyncStreamReader55 
<55 
LongGreetRequest55 /
>55/ 0#
_longGreetRequestStream551 H
;55H I
public77 

override77 
Task77 
<77 
LongGreetResponse77 *
>77* +
	LongGreet77, 5
(775 6
IAsyncStreamReader776 H
<77H I
LongGreetRequest77I Y
>77Y Z
requestStream77[ h
,77h i
ServerCallContext77j {
context	77| É
)
77É Ñ
{
77Ö Ü#
_longGreetRequestStream88 
=88 
requestStream88  -
;88- .
return:: 
LongGreetAsync:: 
(:: 
):: 
;:: 
};; 
private== 
async== 
Task== 
<== 
LongGreetResponse== (
>==( )
LongGreetAsync==* 8
(==8 9
)==9 :
{==; <
var>> 	
result>>
 
=>> 
new>> 
StringBuilder>> $
(>>$ %
)>>% &
.?? 	

AppendLine??	 
(?? 
$str??  
)??  !
;??! "
whileAA 
(AA 
awaitAA #
_longGreetRequestStreamAA *
.AA* +
MoveNextAA+ 3
(AA3 4
)AA4 5
)AA5 6
{AA7 8
varBB 
greetingBB 
=BB #
_longGreetRequestStreamBB .
.BB. /
CurrentBB/ 6
.BB6 7
GreetingBB7 ?
;BB? @
varCC 
messageCC 
=CC 
$"CC 
$strCC 
{CC 
greetingCC '
.CC' (
	FirstNameCC( 1
}CC1 2
$strCC2 3
{CC3 4
greetingCC4 <
.CC< =
LastNameCC= E
}CCE F
"CCF G
;CCG H
resultEE 
.EE 

AppendLineEE 
(EE 
messageEE !
)EE! "
;EE" #
awaitFF #
WriteTextWithDelayAsyncFF %
(FF% &
$"FF& (
$strFF( 2
{FF2 3
greetingFF3 ;
}FF; <
"FF< =
)FF= >
;FF> ?
}GG 
returnII 
newII 
LongGreetResponseII "
{II# $
ResultJJ 
=JJ 
resultJJ 
.JJ 
ToStringJJ  
(JJ  !
)JJ! "
}KK 
;KK 
}LL 
privateRR 
IAsyncStreamReaderRR 
<RR  
GreetEveryoneRequestRR 3
>RR3 4'
_greetEveryoneRequestStreamRR5 P
;RRP Q
privateSS 
IServerStreamWriterSS 
<SS  !
GreetEveryoneResponseSS  5
>SS5 6(
_greetEveryoneResponseStreamSS7 S
;SSS T
publicUU 

overrideUU 
TaskUU 
GreetEveryoneUU &
(UU& '
IAsyncStreamReaderUU' 9
<UU9 : 
GreetEveryoneRequestUU: N
>UUN O
requestStreamUUP ]
,UU] ^
IServerStreamWriterUU_ r
<UUr s"
GreetEveryoneResponse	UUs à
>
UUà â
responseStream
UUä ò
,
UUò ô
ServerCallContext
UUö ´
context
UU¨ ≥
)
UU≥ ¥
{
UUµ ∂'
_greetEveryoneRequestStreamVV !
=VV" #
requestStreamVV$ 1
;VV1 2(
_greetEveryoneResponseStreamWW "
=WW# $
responseStreamWW% 3
;WW3 4
returnYY 
GreetEveryoneAsyncYY 
(YY  
)YY  !
;YY! "
}ZZ 
private\\ 
async\\ 
Task\\ 
GreetEveryoneAsync\\ )
(\\) *
)\\* +
{\\, -
while]] 
(]] 
await]] '
_greetEveryoneRequestStream]] .
.]]. /
MoveNext]]/ 7
(]]7 8
)]]8 9
)]]9 :
{]]; <
var^^ 
greeting^^ 
=^^ '
_greetEveryoneRequestStream^^ 2
.^^2 3
Current^^3 :
.^^: ;
Greeting^^; C
;^^C D
var__ 
message__ 
=__ 
$"__ 
$str__ 
{__ 
greeting__ '
.__' (
	FirstName__( 1
}__1 2
$str__2 3
{__3 4
greeting__4 <
.__< =
LastName__= E
}__E F
"__F G
;__G H
var`` 
response`` 
=`` 
new`` !
GreetEveryoneResponse`` 0
{``1 2
Resultaa
 
=aa 
messageaa 
}bb 	
;bb	 

awaitdd #
WriteTextWithDelayAsyncdd %
(dd% &
$"dd& (
$strdd( >
{dd> ?
greetingdd? G
}ddG H
$strddH J
{ddJ K
DateTimeddK S
.ddS T
NowddT W
.ddW X
SecondddX ^
}dd^ _
$strdd_ `
{dd` a
DateTimedda i
.ddi j
Nowddj m
.ddm n
Millisecondddn y
}ddy z
$strddz {
"dd{ |
)dd| }
;dd} ~
awaitff (
_greetEveryoneResponseStreamff *
.ff* +

WriteAsyncff+ 5
(ff5 6
responseff6 >
)ff> ?
;ff? @
}gg 
}hh 
privatenn 
Tasknn #
WriteTextWithDelayAsyncnn (
(nn( )
stringnn) /
textnn0 4
)nn4 5
{nn6 7
Consoleoo 
.oo 
	WriteLineoo 
(oo 
textoo 
)oo 
;oo 
returnpp 
Taskpp 
.pp 
Delaypp 
(pp 
$numpp 
)pp 
;pp 
}qq 
}uu 
}vv ú
SC:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcServer\Services\SqrtServiceImp.cs
	namespace 	

GrpcServer
 
. 
Services 
{ 
public 
class	 
SqrtServiceImp 
: 
SqrtService  +
.+ ,
SqrtServiceBase, ;
{< =
public		 

override		 
Task		 
<		 
SqrtResponse		 %
>		% &
GetSqrt		' .
(		. /
SqrtRequest		/ :
request		; B
,		B C
ServerCallContext		D U
context		V ]
)		] ^
{		_ `
var

 	
number


 
=

 
request

 
.

 
Number

 !
;

! "
if 
(	 

number
 
>= 
$num 
) 
{ 
var 
response 
= 
new 
SqrtResponse '
{( )

SquareRoot
 
= 
Math 
. 
Sqrt  
(  !
number! '
)' (
} 	
;	 

return 
Task 
. 

FromResult 
( 
response '
)' (
;( )
} 
else 

{ 
throw 
new 
RpcException 
( 
new "
Status# )
() *

StatusCode* 4
.4 5
InvalidArgument5 D
,D E
$strF R
)R S
)S T
;T U
} 
} 
public 

override 
async 
Task 
GetSqrtManyTimes /
(/ 0 
SqrtManyTimesRequest0 D
requestE L
,L M
IServerStreamWriterN a
<a b!
SqrtManyTimesResponseb w
>w x
responseStream	y á
,
á à
ServerCallContext
â ö
context
õ ¢
)
¢ £
{
§ •
await 
Task 
. 
Delay 
( 
$num 
) 
; 
var 	
number
 
= 
request 
. 
Number !
;! "
var 	
response
 
= 
new !
SqrtManyTimesResponse .
{/ 0

SquareRoot 
= 
Math 
. 
Sqrt 
( 
number %
)% &
} 
; 
foreach 
( 
var 
_ 
in 

Enumerable "
." #
Range# (
(( )
$num) *
,* +
$num, -
)- .
). /
{0 1
await   
responseStream   
.   

WriteAsync   '
(  ' (
response  ( 0
)  0 1
;  1 2
}!! 
}"" 
}## 
}$$ 