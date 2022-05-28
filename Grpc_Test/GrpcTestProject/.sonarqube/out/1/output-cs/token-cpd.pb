»
WC:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcClient\Abstractions\ClientStrategy.cs
	namespace 	

GrpcClient
 
. 
Abstractions !
{" #
public 
abstract	 
class 
ClientStrategy &
{' (
public 

abstract 
Task 
CallClientAsync (
(( )
)) *
;* +
} 
} ≈
QC:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcClient\Abstractions\Launcher.cs
	namespace 	

GrpcClient
 
. 
Abstractions !
{" #
public 
abstract	 
class 
Launcher  
{! "
public 

async 
Task 
LaunchAsync !
(! "
)" #
{$ %
try 	
{
 
Console		 
.		 
	WriteLine		 
(		 
$str		 3
)		3 4
;		4 5$
PrintClientStrategyTypes

  
(

  !
)

! "
;

" #
var 
clientStrategyType 
=  #
EnterClientStrategyType! 8
(8 9
)9 :
;: ;
var 
clientStrategy 
= 
GetClientStrategy .
(. /
clientStrategyType/ A
)A B
;B C
await 
clientStrategy 
. 
CallClientAsync ,
(, -
)- .
;. /
} 
catch 
( 
	Exception 
ex 
) 
{ 
Console 
. 
	WriteLine 
( 
$" 
$str 3
{3 4
ex4 6
.6 7
Message7 >
}> ?
"? @
)@ A
;A B
} 
} 
private 
void $
PrintClientStrategyTypes )
() *
)* +
{, -
foreach 
( 
var 
type 
in 
Enum 
.  
	GetValues  )
<) *
ClientStrategyType* <
>< =
(= >
)> ?
)? @
{A B
Console 
. 
	WriteLine 
( 
$" 
{ 
( 
int !
)! "
type" &
}& '
$str' *
{* +
type+ /
}/ 0
"0 1
)1 2
;2 3
} 
} 
private 
ClientStrategyType #
EnterClientStrategyType 6
(6 7
)7 8
{9 :
if 
(	 

int
 
. 
TryParse 
( 
Console 
. 
ReadLine '
(' (
)( )
,) *
out+ .
var/ 2
clientStrategyType3 E
)E F
)F G
{H I
return 
( 
ClientStrategyType "
)" #
clientStrategyType# 5
;5 6
} 
return!! 
ClientStrategyType!! 
.!!  
None!!  $
;!!$ %
}"" 
	protected$$ 
abstract$$ 
ClientStrategy$$ %
GetClientStrategy$$& 7
($$7 8
ClientStrategyType$$8 J
clientStrategyType$$K ]
)$$] ^
;$$^ _
}%% 
}&& ê
TC:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcClient\Enums\ClientStrategyType.cs
	namespace 	

GrpcClient
 
. 
Enums 
{ 
public 
enum	 
ClientStrategyType  
{! "
None 
=	 

$num 
, 
UnaryRequest 
= 
$num 
, 
ServerStreaming 
= 
$num 
, 
ClientStreaming 
= 
$num 
, "
BiDirectionalStreaming 
= 
$num 
} 
}		 ú
NC:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcClient\Enums\LauncherType.cs
	namespace 	

GrpcClient
 
. 
Enums 
{ 
public 
enum	 
LauncherType 
{ 
None 
=	 

$num 
, 
Lesson 

= 
$num 
, 
Advanced 
= 
$num 
, 
Practice 
= 
$num 
} 
} ®
SC:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcClient\Handlers\ChannelHandler.cs
	namespace 	

GrpcClient
 
. 
Handlers 
{ 
public 
class	 
ChannelHandler 
: 
IAsyncDisposable  0
{1 2
private		 
const		 
int		  
DEFAULT_CHANNEL_PORT		 *
=		+ ,
$num		- 2
;		2 3
private

 
const

 
string

  
DEFAULT_CHANNEL_HOST

 -
=

. /
$str

0 ;
;

; <
private 
readonly 
static 
ChannelCredentials .'
DEFAULT_CHANNEL_CREDENTIALS/ J
=K L
ChannelCredentialsM _
._ `
Insecure` h
;h i
private 
Channel 
_channel 
; 
private 
ChannelHandler 
( 
Channel "
channel# *
)* +
{, -
_channel 
= 
channel 
; 
} 
public 

Channel 
Channel 
=> 
_channel &
;& '
public!! 

static!! 
Task!! 
<!! 
ChannelHandler!! %
>!!% &"
GetChannelHandlerAsync!!' =
(!!= >
)!!> ?
{!!@ A
return"" "
GetChannelHandlerAsync"" #
(""# $ 
DEFAULT_CHANNEL_HOST""$ 8
,""8 9 
DEFAULT_CHANNEL_PORT"": N
,""N O'
DEFAULT_CHANNEL_CREDENTIALS""P k
)""k l
;""l m
}## 
public%% 

static%% 
async%% 
Task%% 
<%% 
ChannelHandler%% +
>%%+ ,"
GetChannelHandlerAsync%%- C
(%%C D
string%%D J
host%%K O
,%%O P
int%%Q T
port%%U Y
,%%Y Z
ChannelCredentials%%[ m
credentials%%n y
)%%y z
{%%{ |
var&& 	
channel&&
 
=&& 
new&& 
Channel&& 
(&&  
host&&  $
,&&$ %
port&&& *
,&&* +
credentials&&, 7
)&&7 8
;&&8 9
await'' 
channel'' 
.'' 
ConnectAsync''  
(''  !
)''! "
;''" #
return)) 
new)) 
ChannelHandler)) 
())  
channel))  '
)))' (
;))( )
}** 
public00 

async00 
	ValueTask00 
DisposeAsync00 '
(00' (
)00( )
{00* +
await11 
DisposeAsyncCore11 
(11 
)11 
;11 
GC22 
.22 	
SuppressFinalize22	 
(22 
this22 
)22 
;22  
}33 
	protected55 
virtual55 
async55 
	ValueTask55 %
DisposeAsyncCore55& 6
(556 7
)557 8
{559 :
if66 
(66	 

_channel66
 
!=66 
null66 
)66 
{66 
await77  
ShutdownChannelAsync77 "
(77" #
)77# $
;77$ %
}88 
_channel:: 
=:: 
null:: 
;:: 
};; 
private== 
Task==  
ShutdownChannelAsync== %
(==% &
)==& '
{==( )
if>> 
(>>	 

_channel>>
 
.>> 
State>> 
==>> 
ChannelState>> (
.>>( )
Shutdown>>) 1
)>>1 2
{>>3 4
return?? 
Task?? 
.?? 
CompletedTask?? !
;??! "
}@@ 
returnBB 
_channelBB 
.BB 
ShutdownAsyncBB #
(BB# $
)BB$ %
;BB% &
}CC 
}FF 
}GG Í
VC:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcClient\Launchers\AdvancedLauncher.cs
	namespace 	

GrpcClient
 
. 
	Launchers 
{  
public 
class	 
AdvancedLauncher 
:  !
Launcher" *
{+ ,
	protected 
override 
ClientStrategy %
GetClientStrategy& 7
(7 8
ClientStrategyType8 J
clientStrategyTypeK ]
)] ^
=>_ a
clientStrategyTypeb t
switchu {
{| }
ClientStrategyType 
. 
UnaryRequest %
=>& (
new) , 
URSqrtClientStrategy- A
(A B
)B C
,C D
ClientStrategyType		 
.		 
ServerStreaming		 (
=>		) +
new		, / 
SSSqrtClientStrategy		0 D
(		D E
)		E F
,		F G
_

 
=>

 

new

 
EmptyClientStrategy

 "
(

" #
)

# $
} 
; 
} 
} §
SC:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcClient\Launchers\EmptyLauncher.cs
	namespace 	

GrpcClient
 
. 
	Launchers 
{  
public 
class	 
EmptyLauncher 
: 
Launcher '
{( )
	protected 
override 
ClientStrategy %
GetClientStrategy& 7
(7 8
ClientStrategyType8 J
clientStrategyTypeK ]
)] ^
{_ `
Console

 
.

 
	WriteLine

 
(

 
$"

 
{

 
nameof

 !
(

! "
EmptyLauncher

" /
)

/ 0
}

0 1
$str

1 6
"

6 7
)

7 8
;

8 9
return 
new 
EmptyClientStrategy $
($ %
)% &
;& '
} 
} 
} ı
TC:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcClient\Launchers\LessonLauncher.cs
	namespace 	

GrpcClient
 
. 
	Launchers 
{  
public 
class	 
LessonLauncher 
: 
Launcher  (
{) *
	protected 
override 
ClientStrategy %
GetClientStrategy& 7
(7 8
ClientStrategyType8 J
clientStrategyTypeK ]
)] ^
=>_ a
clientStrategyTypeb t
switchu {
{| }
ClientStrategyType 
. 
UnaryRequest %
=>& (
new) ,$
URGreetingClientStrategy- E
(E F
)F G
,G H
ClientStrategyType		 
.		 
ServerStreaming		 (
=>		) +
new		, /$
SSGreetingClientStrategy		0 H
(		H I
)		I J
,		J K
ClientStrategyType

 
.

 
ClientStreaming

 (
=>

) +
new

, /$
CSGreetingClientStrategy

0 H
(

H I
)

I J
,

J K
ClientStrategyType 
. "
BiDirectionalStreaming /
=>0 2
new3 6$
BDGreetingClientStrategy7 O
(O P
)P Q
,Q R
_ 
=> 

new 
EmptyClientStrategy "
(" #
)# $
} 
; 
} 
} Å
VC:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcClient\Launchers\PracticeLauncher.cs
	namespace 	

GrpcClient
 
. 
	Launchers 
{  
public 
class	 
PracticeLauncher 
:  !
Launcher" *
{+ ,
	protected 
override 
ClientStrategy %
GetClientStrategy& 7
(7 8
ClientStrategyType8 J
clientStrategyTypeK ]
)] ^
=>_ a
clientStrategyTypeb t
switchu {
{| }
ClientStrategyType 
. 
UnaryRequest %
=>& (
new) ,&
URCalculatorClientStrategy- G
(G H
)H I
,I J
ClientStrategyType		 
.		 
ServerStreaming		 (
=>		) +
new		, /&
SSCalculatorClientStrategy		0 J
(		J K
)		K L
,		L M
ClientStrategyType

 
.

 
ClientStreaming

 (
=>

) +
new

, /&
CSCalculatorClientStrategy

0 J
(

J K
)

K L
,

L M
ClientStrategyType 
. "
BiDirectionalStreaming /
=>0 2
new3 6&
BDCalculatorClientStrategy7 Q
(Q R
)R S
,S T
_ 
=> 

new 
EmptyClientStrategy "
(" #
)# $
} 
; 
} 
} å
CC:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcClient\Program.cs
	namespace 	

GrpcClient
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
{		% &
while

 
(

 
true

 
)

 
{

 
Console 
. 
	WriteLine 
( 
$str ,
), -
;- .
PrintLauncherTypes 
( 
) 
; 
var 
launcherType 
= 
EnterLauncherType ,
(, -
)- .
;. /
var 
launcher 
= 
GetLauncher "
(" #
launcherType# /
)/ 0
;0 1
if 

( 
launcher 
. 
GetType 
( 
) 
== !
typeof" (
(( )
EmptyLauncher) 6
)6 7
)7 8
{9 :
break
 
; 
} 	
await 
launcher 
. 
LaunchAsync "
(" #
)# $
;$ %
} 
} 
private 
static 
void 
PrintLauncherTypes *
(* +
)+ ,
{- .
foreach 
( 
var 
type 
in 
Enum 
.  
	GetValues  )
<) *
LauncherType* 6
>6 7
(7 8
)8 9
)9 :
{; <
Console 
. 
	WriteLine 
( 
$" 
{ 
( 
int !
)! "
type" &
}& '
$str' *
{* +
type+ /
}/ 0
"0 1
)1 2
;2 3
} 
} 
private 
static 
LauncherType 
EnterLauncherType  1
(1 2
)2 3
{4 5
if   
(  	 

int  
 
.   
TryParse   
(   
Console   
.   
ReadLine   '
(  ' (
)  ( )
,  ) *
out  + .
int  / 2
launcherType  3 ?
)  ? @
)  @ A
{  B C
return!! 
(!! 
LauncherType!! 
)!! 
launcherType!! )
;!!) *
}"" 
return$$ 
LauncherType$$ 
.$$ 
None$$ 
;$$ 
}%% 
private'' 
static'' 
Launcher'' 
GetLauncher'' '
(''' (
LauncherType''( 4
launcherType''5 A
)''A B
=>''C E
launcherType''F R
switch''S Y
{''Z [
LauncherType(( 
.(( 
Lesson(( 
=>(( 
new((  
LessonLauncher((! /
(((/ 0
)((0 1
,((1 2
LauncherType)) 
.)) 
Advanced)) 
=>)) 
new)) "
AdvancedLauncher))# 3
())3 4
)))4 5
,))5 6
LauncherType** 
.** 
Practice** 
=>** 
new** "
PracticeLauncher**# 3
(**3 4
)**4 5
,**5 6
_++ 
=>++ 

new++ 
EmptyLauncher++ 
(++ 
)++ 
,++ 
},, 
;,, 
}-- 
}.. Í
aC:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcClient\Strategies\BDCalculatorClientStrategy.cs
	namespace		 	

GrpcClient		
 
.		 

Strategies		 
{		  !
public

 
class

	 &
BDCalculatorClientStrategy

 )
:

* +
ClientStrategy

, :
{

; <
public 

override 
async 
Task 
CallClientAsync .
(. /
)/ 0
{1 2
await 
using 
var 
channelHandler $
=% &
await' ,
ChannelHandler- ;
.; <"
GetChannelHandlerAsync< R
(R S
)S T
;T U
var 	
client
 
= 
new 
CalculatorService (
.( )#
CalculatorServiceClient) @
(@ A
channelHandlerA O
.O P
ChannelP W
)W X
;X Y
var 	
stream
 
= 
client 
. 
CalculateMaximumm +
(+ ,
), -
;- .
await 
WriteRequestAsync 
( 
stream $
.$ %
RequestStream% 2
)2 3
;3 4
await 
PrintResponseAsync 
( 
stream %
.% &
ResponseStream& 4
)4 5
;5 6
} 
private 
async 
Task 
WriteRequestAsync (
(( )
IClientStreamWriter) <
<< =
MaximumRequest= K
>K L
requestStreamWriterM `
)` a
{b c
var 	
numbers
 
= 
new 
List 
< 
int  
>  !
{" #
$num$ %
,% &
$num' (
,( )
$num* +
,+ ,
$num- .
,. /
$num0 1
,1 2
$num3 5
}6 7
;7 8
foreach 
( 
var 
number 
in 
numbers $
)$ %
{& '
var 
request 
= 
new 
MaximumRequest (
{) *
Number
 
= 
number 
} 	
;	 

await 
requestStreamWriter !
.! "

WriteAsync" ,
(, -
request- 4
)4 5
;5 6
} 
await 
requestStreamWriter 
.  
CompleteAsync  -
(- .
). /
;/ 0
}   
private"" 
async"" 
Task"" 
PrintResponseAsync"" )
("") *
IAsyncStreamReader""* <
<""< =
MaximumResponse""= L
>""L M 
responseStreamReader""N b
)""b c
{""d e
while## 
(## 
await##  
responseStreamReader## '
.##' (
MoveNext##( 0
(##0 1
)##1 2
)##2 3
{##4 5
Console$$ 
.$$ 
	WriteLine$$ 
($$ 
$"$$ 
$str$$ .
{$$. / 
responseStreamReader$$/ C
.$$C D
Current$$D K
.$$K L
	MaxNumber$$L U
}$$U V
"$$V W
)$$W X
;$$X Y
}%% 
}&& 
}'' 
}(( ú(
_C:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcClient\Strategies\BDGreetingClientStrategy.cs
	namespace 	

GrpcClient
 
. 

Strategies 
{  !
public		 
class			 $
BDGreetingClientStrategy		 '
:		( )
ClientStrategy		* 8
{		9 :
public

 

override

 
async

 
Task

 
CallClientAsync

 .
(

. /
)

/ 0
{

1 2
await 
using 
var 
channelHandler $
=% &
await' ,
ChannelHandler- ;
.; <"
GetChannelHandlerAsync< R
(R S
)S T
;T U
var 	
client
 
= 
new 
GreetingService &
.& '!
GreetingServiceClient' <
(< =
channelHandler= K
.K L
ChannelL S
)S T
;T U
var 	
stream
 
= 
client 
. 
GreetEveryone '
(' (
)( )
;) *
await 
WriteRequestAsync 
( 
stream $
.$ %
RequestStream% 2
)2 3
;3 4
await 
PrintResponseAsync 
( 
stream %
.% &
ResponseStream& 4
)4 5
;5 6
} 
private 
async 
Task 
WriteRequestAsync (
(( )
IClientStreamWriter) <
<< = 
GreetEveryoneRequest= Q
>Q R
requestStreamWriterS f
)f g
{h i
foreach 
( 
var 
greeting 
in 
GenerateGreetings 0
(0 1
)1 2
)2 3
{4 5
var 
request 
= 
new  
GreetEveryoneRequest .
{/ 0
Greeting
 
= 
greeting 
} 	
;	 

await 
requestStreamWriter !
.! "

WriteAsync" ,
(, -
request- 4
)4 5
;5 6
} 
await 
requestStreamWriter 
.  
CompleteAsync  -
(- .
). /
;/ 0
} 
private   
async   
Task   
PrintResponseAsync   )
(  ) *
IAsyncStreamReader  * <
<  < =!
GreetEveryoneResponse  = R
>  R S 
responseStreamReader  T h
)  h i
{  j k
while!! 
(!! 
await!!  
responseStreamReader!! '
.!!' (
MoveNext!!( 0
(!!0 1
)!!1 2
)!!2 3
{!!4 5
Console"" 
."" 
	WriteLine"" 
("" 
$""" 
$str"" 3
{""3 4 
responseStreamReader""4 H
.""H I
Current""I P
.""P Q
Result""Q W
}""W X
$str""X Z
{""Z [
DateTime""[ c
.""c d
Now""d g
.""g h
Second""h n
}""n o
$str""o p
{""p q
DateTime""q y
.""y z
Now""z }
.""} ~
Millisecond	""~ â
}
""â ä
$str
""ä ã
"
""ã å
)
""å ç
;
""ç é
}## 
}$$ 
private&& 
Greeting&& 
.&& 
Greeting&& 
[&& 
]&& 
GenerateGreetings&&  1
(&&1 2
)&&2 3
{&&4 5
return'' 
new'' 
Greeting'' 
.'' 
Greeting'' "
[''" #
]''# $
{''% &
new(( 
Greeting(( 
.(( 
Greeting(( 
{(( 
	FirstName))
 
=)) 
$str)) 
,)) 
LastName**
 
=** 
$str** "
}++ 	
,++	 

new,, 
Greeting,, 
.,, 
Greeting,, 
{,, 
	FirstName--
 
=-- 
$str-- 
,-- 
LastName..
 
=.. 
$str.. 
}// 	
,//	 

new00 
Greeting00 
.00 
Greeting00 
{00 
	FirstName11
 
=11 
$str11 
,11 
LastName22
 
=22 
$str22 
}33 	
,33	 

new44 
Greeting44 
.44 
Greeting44 
{44 
	FirstName55
 
=55 
$str55 
,55 
LastName66
 
=66 
$str66 
}77 	
,77	 

new88 
Greeting88 
.88 
Greeting88 
{88 
	FirstName99
 
=99 
$str99 
,99 
LastName::
 
=:: 
$str:: 
};; 	
}<< 
;<< 
}== 
}>> 
}?? °
aC:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcClient\Strategies\CSCalculatorClientStrategy.cs
	namespace		 	

GrpcClient		
 
.		 

Strategies		 
{		  !
public

 
class

	 &
CSCalculatorClientStrategy

 )
:

* +
ClientStrategy

, :
{

; <
public 

override 
async 
Task 
CallClientAsync .
(. /
)/ 0
{1 2
await 
using 
var 
channelHandler $
=% &
await' ,
ChannelHandler- ;
.; <"
GetChannelHandlerAsync< R
(R S
)S T
;T U
var 	
client
 
= 
new 
CalculatorService (
.( )#
CalculatorServiceClient) @
(@ A
channelHandlerA O
.O P
ChannelP W
)W X
;X Y
var 	

callStream
 
= 
client 
. 
CalculateAverage .
(. /
)/ 0
;0 1
await 
WriteRequestAsync 
( 

callStream (
.( )
RequestStream) 6
)6 7
;7 8
PrintResponse 
( 
await 

callStream $
.$ %
ResponseAsync% 2
)2 3
;3 4
} 
private 
async 
Task 
WriteRequestAsync (
(( )
IClientStreamWriter) <
<< =
AverageRequest= K
>K L
requestStreamWriterM `
)` a
{b c
foreach 
( 
int 
i 
in 

Enumerable "
." #
Range# (
(( )
$num) *
,* +
$num, -
)- .
). /
{0 1
var 
request 
= 
new 
AverageRequest (
{) *
Number
 
= 
i 
} 	
;	 

await 
requestStreamWriter !
.! "

WriteAsync" ,
(, -
request- 4
)4 5
;5 6
await 
Task 
. 
Delay 
( 
$num 
) 
; 
} 
await 
requestStreamWriter 
.  
CompleteAsync  -
(- .
). /
;/ 0
}   
private"" 
void"" 
PrintResponse"" 
("" 
AverageResponse"" .
response""/ 7
)""7 8
{""9 :
Console## 
.## 
	WriteLine## 
(## 
$"## 
$str## ,
{##, -
response##- 5
.##5 6
AverageNumber##6 C
}##C D
"##D E
)##E F
;##F G
}$$ 
}%% 
}&& ⁄
_C:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcClient\Strategies\CSGreetingClientStrategy.cs
	namespace		 	

GrpcClient		
 
.		 

Strategies		 
{		  !
public

 
class

	 $
CSGreetingClientStrategy

 '
:

( )
ClientStrategy

* 8
{

9 :
public 

override 
async 
Task 
CallClientAsync .
(. /
)/ 0
{1 2
await 
using 
var 
channelHandler $
=% &
await' ,
ChannelHandler- ;
.; <"
GetChannelHandlerAsync< R
(R S
)S T
;T U
var 	
client
 
= 
new 
GreetingService &
.& '!
GreetingServiceClient' <
(< =
channelHandler= K
.K L
ChannelL S
)S T
;T U
var 	
stream
 
= 
client 
. 
	LongGreet #
(# $
)$ %
;% &
await 
WriteRequestAsync 
( 
stream $
.$ %
RequestStream% 2
)2 3
;3 4
PrintResponse 
( 
await 
stream  
.  !
ResponseAsync! .
). /
;/ 0
} 
private 
async 
Task 
WriteRequestAsync (
(( )
IClientStreamWriter) <
<< =
LongGreetRequest= M
>M N
requestStreamWriterO b
)b c
{d e
var 	
request
 
= 
new 
LongGreetRequest (
{) *
Greeting 
= 
new 
Greeting 
.  
Greeting  (
{) *
	FirstName
 
= 
$str 
, 
LastName
 
= 
$str "
} 	
} 
; 
foreach 
( 
int 
_ 
in 

Enumerable "
." #
Range# (
(( )
$num) *
,* +
$num, .
). /
)/ 0
{1 2
await 
requestStreamWriter !
.! "

WriteAsync" ,
(, -
request- 4
)4 5
;5 6
} 
await!! 
requestStreamWriter!! 
.!!  
CompleteAsync!!  -
(!!- .
)!!. /
;!!/ 0
}"" 
private$$ 
void$$ 
PrintResponse$$ 
($$ 
LongGreetResponse$$ 0
response$$1 9
)$$9 :
{$$; <
Console%% 
.%% 
	WriteLine%% 
(%% 
$"%% 
$str%% ,
{%%, -
response%%- 5
.%%5 6
Result%%6 <
}%%< =
"%%= >
)%%> ?
;%%? @
}&& 
}'' 
}(( ü
ZC:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcClient\Strategies\EmptyClientStrategy.cs
	namespace 	

GrpcClient
 
. 

Strategies 
{  !
public 
class	 
EmptyClientStrategy "
:# $
ClientStrategy% 3
{4 5
public 

override 
Task 
CallClientAsync (
(( )
)) *
{+ ,
PrintWarning		 
(		 
)		 
;		 
return

 
Task

 
.

 
CompletedTask

 
;

  
} 
private 
void 
PrintWarning 
( 
) 
{  !
Console 
. 
	WriteLine 
( 
$" 
{ 
nameof !
(! "
EmptyClientStrategy" 5
)5 6
}6 7
$str7 <
"< =
)= >
;> ?
} 
} 
} Ω
aC:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcClient\Strategies\SSCalculatorClientStrategy.cs
	namespace 	

GrpcClient
 
. 

Strategies 
{  !
public		 
class			 &
SSCalculatorClientStrategy		 )
:		* +
ClientStrategy		, :
{		; <
public

 

override

 
async

 
Task

 
CallClientAsync

 .
(

. /
)

/ 0
{

1 2
await 
using 
var 
channelHandler $
=% &
await' ,
ChannelHandler- ;
.; <"
GetChannelHandlerAsync< R
(R S
)S T
;T U
var 	
client
 
= 
new 
CalculatorService (
.( )#
CalculatorServiceClient) @
(@ A
channelHandlerA O
.O P
ChannelP W
)W X
;X Y
var 	
callRequest
 
= 
new  
DecompositionRequest 0
{1 2
PrimeNumber 
= 
$num 
} 
; 
var 	
callResponse
 
= 
client 
.  "
CalculateDecomposition  6
(6 7
callRequest7 B
)B C
;C D
await 
PrintResponseAsync 
( 
callResponse +
.+ ,
ResponseStream, :
): ;
;; <
} 
private 
async 
Task 
PrintResponseAsync )
() *
IAsyncStreamReader* <
<< =!
DecompositionResponse= R
>R S
responseStreamT b
)b c
{d e
while 
( 
await 
responseStream !
.! "
MoveNext" *
(* +
)+ ,
), -
{. /
Console 
. 
	WriteLine 
( 
$" 
$str .
{. /
responseStream/ =
.= >
Current> E
.E F
DividerF M
}M N
"N O
)O P
;P Q
await 
Task 
. 
Delay 
( 
$num 
) 
; 
} 
} 
} 
} Å
_C:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcClient\Strategies\SSGreetingClientStrategy.cs
	namespace 	

GrpcClient
 
. 

Strategies 
{  !
public		 
class			 $
SSGreetingClientStrategy		 '
:		( )
ClientStrategy		* 8
{		9 :
public

 

override

 
async

 
Task

 
CallClientAsync

 .
(

. /
)

/ 0
{

1 2
await 
using 
var 
channelHandler $
=% &
await' ,
ChannelHandler- ;
.; <"
GetChannelHandlerAsync< R
(R S
)S T
;T U
var 	
client
 
= 
new 
GreetingService &
.& '!
GreetingServiceClient' <
(< =
channelHandler= K
.K L
ChannelL S
)S T
;T U
var 	
callRequest
 
= 
new !
GreetManyTimesRequest 1
{2 3
Greeting 
= 
new 
Greeting 
.  
Greeting  (
{) *
	FirstName
 
= 
$str 
, 
LastName
 
= 
$str "
} 	
} 
; 
var 	
callResponse
 
= 
client 
.  
GreetManyTimes  .
(. /
callRequest/ :
): ;
;; <
await 
PrintResponseAsync 
( 
callResponse +
.+ ,
ResponseStream, :
): ;
;; <
} 
private 
async 
Task 
PrintResponseAsync )
() *
IAsyncStreamReader* <
<< ="
GreetManyTimesResponse= S
>S T
responseStreamU c
)c d
{e f
while 
( 
await 
responseStream !
.! "
MoveNext" *
(* +
)+ ,
), -
{. /
Console 
. 
	WriteLine 
( 
$" 
$str .
{. /
responseStream/ =
.= >
Current> E
.E F
ResultF L
}L M
"M N
)N O
;O P
await 
Task 
. 
Delay 
( 
$num 
) 
; 
} 
} 
} 
} »
[C:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcClient\Strategies\SSSqrtClientStrategy.cs
	namespace 	

GrpcClient
 
. 

Strategies 
{  !
public		 
class			  
SSSqrtClientStrategy		 #
:		$ %
ClientStrategy		& 4
{		5 6
public

 

override

 
async

 
Task

 
CallClientAsync

 .
(

. /
)

/ 0
{

1 2
await 
using 
var 
channelHandler $
=% &
await' ,
ChannelHandler- ;
.; <"
GetChannelHandlerAsync< R
(R S
)S T
;T U
var 	
client
 
= 
new 
SqrtService "
." #
SqrtServiceClient# 4
(4 5
channelHandler5 C
.C D
ChannelD K
)K L
;L M
try 	
{
 
var 
callRequest 
= 
new  
SqrtManyTimesRequest 2
{3 4
Number
 
= 
$num 
} 	
;	 

var 
deadlineTime 
= 
DateTime #
.# $
UtcNow$ *
.* +
AddMilliseconds+ :
(: ;
$num; >
)> ?
;? @
var 
callResponse 
= 
client !
.! "
GetSqrtManyTimes" 2
(2 3
callRequest3 >
,> ?
deadline@ H
:H I
deadlineTimeJ V
)V W
;W X
await 
PrintResponseAsync  
(  !
callResponse! -
.- .
ResponseStream. <
)< =
;= >
} 
catch 
( 
RpcException 
re 
) 
when "
(# $
re$ &
.& '

StatusCode' 1
==2 4

StatusCode5 ?
.? @
DeadlineExceeded@ P
)P Q
{R S
PrintRpcError 
( 
re 
) 
; 
} 
} 
private 
async 
Task 
PrintResponseAsync )
() *
IAsyncStreamReader* <
<< =!
SqrtManyTimesResponse= R
>R S
responseStreamT b
)b c
{d e
while 
( 
await 
responseStream !
.! "
MoveNext" *
(* +
)+ ,
), -
{. /
Console 
. 
	WriteLine 
( 
$" 
$str .
{. /
responseStream/ =
.= >
Current> E
.E F

SquareRootF P
}P Q
"Q R
)R S
;S T
await 
Task 
. 
Delay 
( 
$num 
) 
; 
}   
}!! 
private## 
void## 
PrintRpcError## 
(## 
RpcException## +
	exception##, 5
)##5 6
{##7 8
Console$$ 
.$$ 
	WriteLine$$ 
($$ 
$"$$ 
$str$$ 1
{$$1 2
	exception$$2 ;
.$$; <
Status$$< B
.$$B C
Detail$$C I
}$$I J
"$$J K
)$$K L
;$$L M
}%% 
}&& 
}'' Ì
aC:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcClient\Strategies\URCalculatorClientStrategy.cs
	namespace 	

GrpcClient
 
. 

Strategies 
{  !
public 
class	 &
URCalculatorClientStrategy )
:* +
ClientStrategy, :
{; <
public		 

override		 
async		 
Task		 
CallClientAsync		 .
(		. /
)		/ 0
{		1 2
await

 
using

 
var

 
channelHandler

 $
=

% &
await

' ,
ChannelHandler

- ;
.

; <"
GetChannelHandlerAsync

< R
(

R S
)

S T
;

T U
var 	
client
 
= 
new 
CalculatorService (
.( )#
CalculatorServiceClient) @
(@ A
channelHandlerA O
.O P
ChannelP W
)W X
;X Y
var 	
callRequest
 
= 
new 

SumRequest &
{' (
FirstNumber 
= 
$num 
, 
SecondNumber 
= 
$num 
} 
; 
var 	
callResponse
 
= 
await 
client %
.% &
CalculateSumAsync& 7
(7 8
callRequest8 C
)C D
;D E
PrintResponse 
( 
callResponse  
)  !
;! "
} 
private 
void 
PrintResponse 
( 
SumResponse *
response+ 3
)3 4
{5 6
Console 
. 
	WriteLine 
( 
$" 
$str ,
{, -
response- 5
.5 6
Sum6 9
}9 :
": ;
); <
;< =
} 
} 
} Ù
_C:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcClient\Strategies\URGreetingClientStrategy.cs
	namespace 	

GrpcClient
 
. 

Strategies 
{  !
public 
class	 $
URGreetingClientStrategy '
:( )
ClientStrategy* 8
{9 :
public		 

override		 
async		 
Task		 
CallClientAsync		 .
(		. /
)		/ 0
{		1 2
await

 
using

 
var

 
channelHandler

 $
=

% &
await

' ,
ChannelHandler

- ;
.

; <"
GetChannelHandlerAsync

< R
(

R S
)

S T
;

T U
var 	
client
 
= 
new 
GreetingService &
.& '!
GreetingServiceClient' <
(< =
channelHandler= K
.K L
ChannelL S
)S T
;T U
var 	
callRequest
 
= 
new 
GreetingRequest +
{, -
Greeting 
= 
new 
Greeting 
.  
Greeting  (
{) *
	FirstName
 
= 
$str 
, 
LastName
 
= 
$str "
} 	
} 
; 
var 	
callResponse
 
= 
await 
client %
.% &

GreetAsync& 0
(0 1
callRequest1 <
)< =
;= >
PrintResponse 
( 
callResponse  
)  !
;! "
} 
private 
void 
PrintResponse 
( 
GreetingResponse /
response0 8
)8 9
{: ;
Console 
. 
	WriteLine 
( 
$" 
$str ,
{, -
response- 5
.5 6
Result6 <
}< =
"= >
)> ?
;? @
} 
} 
} ‹
[C:\MyData\Courses\GrpcHandsOn\GrpcTestProject\GrpcClient\Strategies\URSqrtClientStrategy.cs
	namespace 	

GrpcClient
 
. 

Strategies 
{  !
public		 
class			  
URSqrtClientStrategy		 #
:		$ %
ClientStrategy		& 4
{		5 6
public

 

override

 
async

 
Task

 
CallClientAsync

 .
(

. /
)

/ 0
{

1 2
await 
using 
var 
channelHandler $
=% &
await' ,
ChannelHandler- ;
.; <"
GetChannelHandlerAsync< R
(R S
)S T
;T U
var 	
client
 
= 
new 
SqrtService "
." #
SqrtServiceClient# 4
(4 5
channelHandler5 C
.C D
ChannelD K
)K L
;L M
try 	
{
 
var 
callRequest 
= 
new 
SqrtRequest )
{* +
Number
 
= 
- 
$num 
} 	
;	 

var 
callResponse 
= 
await  
client! '
.' (
GetSqrtAsync( 4
(4 5
callRequest5 @
)@ A
;A B
PrintResponse 
( 
callResponse "
)" #
;# $
} 
catch 
( 
RpcException 
re 
) 
{ 
PrintRpcError 
( 
re 
) 
; 
} 
} 
private 
void 
PrintResponse 
( 
SqrtResponse +
response, 4
)4 5
{6 7
Console 
. 
	WriteLine 
( 
$" 
$str ,
{, -
response- 5
.5 6

SquareRoot6 @
}@ A
"A B
)B C
;C D
} 
private 
void 
PrintRpcError 
( 
RpcException +
	exception, 5
)5 6
{7 8
Console   
.   
	WriteLine   
(   
$"   
$str   1
{  1 2
	exception  2 ;
.  ; <
Status  < B
.  B C
Detail  C I
}  I J
"  J K
)  K L
;  L M
}!! 
}"" 
}## 