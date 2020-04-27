include irvine32.inc
INCLUDE macros.inc 
BUFFER_SIZE = 98

.data
easy1b BYTE "E:\Sudoku Boards\diff_1_1.txt",0
easy1s BYTE "E:\Sudoku Boards\diff_1_1_solved.txt",0
easy2b BYTE "E:\Sudoku Boards\diff_1_2.txt",0
easy2s BYTE "E:\Sudoku Boards\diff_1_2_solved.txt",0
easy3b BYTE "E:\Sudoku Boards\diff_1_3.txt",0
easy3s BYTE "E:\Sudoku Boards\diff_1_3_solved.txt",0
 med1b BYTE "E:\Sudoku Boards\diff_2_1.txt",0
 med1s BYTE "E:\Sudoku Boards\diff_2_1_solved.txt",0
 med2b BYTE "E:\Sudoku Boards\diff_2_2.txt",0
 med2s BYTE "E:\Sudoku Boards\diff_2_2_solved.txt",0
 med3b BYTE "E:\Sudoku Boards\diff_2_3.txt",0
 med3s BYTE "E:\Sudoku Boards\diff_2_3_solved.txt",0
hard1b BYTE "E:\Sudoku Boards\diff_3_1.txt",0
hard1s BYTE "E:\Sudoku Boards\diff_3_1_solved.txt",0
hard2b BYTE "E:\Sudoku Boards\diff_3_2.txt",0
hard2s BYTE "E:\Sudoku Boards\diff_3_2_solved.txt",0
hard3b BYTE "E:\Sudoku Boards\diff_3_3.txt",0
hard3s BYTE "E:\Sudoku Boards\diff_3_3_solved.txt",0
loadb BYTE "E:\Sudoku Boards\temp.txt",0
loads BYTE "E:\Sudoku Boards\tempSol.txt",0
loadi BYTE "E:\Sudoku Boards\indeces.txt",0
reportl BYTE "E:\Sudoku Boards\report.txt",0

;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;ReportData;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
rightCount dword 0
wrongCount dword 0
stepsToFinish dword 81
startTime dword 0
endtime dword 0
mSecondsPassed dword 0
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
buffer BYTE BUFFER_SIZE DUP(?)
reversebuffer BYTE 22 dup(?)
fileHandle  HANDLE ?





n1 dword ?
n2 dword ?
boardpath dword ?
solpath dword ?
temp1 dword ?
temp2 dword ?



.code
;;;;;;;;;;;;;;;;;;;;;;;;;;;;startTimer;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;

startTimer PROC
call getmseconds
mov startTime,eax
ret
startTimer ENDP

;;;;;;;;;;;;;;;;;;;;;;;;;;;;stopTimer;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;

stopTimer PROC
call getmseconds
mov endtime,eax
ret
stopTimer ENDP

;;;;;;;;;;;;;;;;;;;;;;;;;;;;updateTime;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;

updateTime PROC
mov eax,endtime

cmp eax,startTime
ja getDifference
add eax,86400000
getDifference:
sub eax,startTime
add mSecondsPassed,eax
ret
updateTime ENDP

;;;;;;;;;;;;;;;;;;;;;;;;;;;;;getMins;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;

getMins Proc
mov eax,mSecondsPassed
mov edx,0
mov ebx,1000*60
div ebx

ret
getMins ENDP

;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;getS;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;

getS PROC
mov eax,mSecondsPassed
mov edx,0
mov ebx,1000*60
div ebx
mov eax,edx
mov edx,0
mov ebx,1000
div ebx

ret
getS ENDP


;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;solve;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;

solve PROC arrboard:ptr dword, arrSolution:ptr dword, arrindex:ptr dword, index : dword
mov eax,4
mul index
mov index,eax

mov esi,arrSolution
add esi,index

mov edi,arrboard
add edi,index

mov ebx,arrindex
add ebx,index

cmp dword ptr [ebx],1
jne check2
mov eax,0
jmp fnEnd

check2:
cmp dword ptr [edi],0
jne check3
mov eax,1
jmp fnend

check3:
mov eax,[esi]
cmp eax,[edi]
jne check4
mov eax,2
jmp fnend

check4:
mov eax,3

fnEnd:
push eax

mov eax,[esi]
mov [edi],eax

pop eax

ret
solve ENDP
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;;;;;;;;;;;;;;;;;;;;;;;;;;;clearBoard;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
clearboard PROC arrboard:ptr dword, arrindex:ptr dword
mov edi,arrboard
mov esi,arrindex
mov ecx,81
L1:

cmp dword ptr [esi], 0
jne defnum

mov dword ptr [edi],0
jmp endlp

defnum:
sub stepsToFinish,1

endlp:
add edi,4
add esi,4

Loop L1

ret
clearboard ENDP


;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;;;;;;;;;;;;;;;;;;;;;;;;;;;clearReport;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;

clearReport PROC

mov rightCount, 0
mov wrongCount, 0
mov stepsToFinish, 81
mov starttime, 0
mov endtime, 0
mov msecondspassed, 0

ret
clearReport ENDP
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;

plotloaded PROC arrboard:ptr dword, arrSolution:ptr dword, arrindex:ptr dword, index : dword
mov eax,4
mul index
mov index,eax

mov esi,arrSolution
add esi,index

mov edi,arrboard
add edi,index

mov ebx,arrindex
add ebx,index

cmp dword ptr [ebx],0
jne check2
mov eax,1
jmp fnEnd

check2:
cmp dword ptr [edi],1
jne check3
mov eax,1
jmp fnend

check3:
mov eax,[esi]
cmp eax,[edi]
jne check4
mov eax,2
jmp fnend

check4:
mov eax,3

fnEnd:
ret
plotloaded ENDP

;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;check;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
check PROC arrboard:ptr dword, arrSolution:ptr dword, index : dword, input: dword

mov esi,arrSolution
mov edi,arrboard
dec index

mov eax,4
mul index
mov index,eax
add esi,index


mov eax,input
add edi,index
mov [edi],eax

mov eax,[esi]
cmp eax,input
jne wrongAns

mov eax,1
inc rightcount
sub stepsToFinish,1
jmp checkResult

wrongAns:
mov eax,0
inc wrongcount

checkResult:
ret
check ENDP

;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;loadreport;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
loadreport PROC

mov edx,offset reportl
call OpenInputFile
mov filehandle,eax

mov edx,OFFSET buffer
mov ecx,BUFFER_SIZE
call ReadFromFile

mov esi,offset buffer
mov ecx,lengthof buffer
mov eax,0
mov temp1,10
mov temp2,0

L1:
push ecx
mov bl,byte ptr [esi]
cmp bl,'0'
jb endofnum
cmp bl,'9'
ja endofnum

sub bl,48
movzx ebx,bl
mul temp1
add eax,ebx
jmp endi


endofnum:
add temp2,1
;add esi,1
mov ecx,temp2

cmp ecx,1
je case1
cmp ecx,2
je case2
cmp ecx,3
je case3
cmp ecx,4
je case4
cmp ecx,5
je case5


case1:
mov rightCount,eax
mov eax,0
jmp endi

case2:
mov wrongCount,eax
mov eax,0
jmp endi

case3:
mov stepsToFinish,eax
mov eax,0
jmp endi

case4:
mov mSecondsPassed,eax
mov eax,0
jmp endi

case5:
pop ecx
jmp break


endi:

add esi,1
pop ecx
loop L1

break:

mov eax,fileHandle
call CloseFile

ret
loadreport ENDP

;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;savereport;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;

savereport PROC
mov temp1,10
mov temp2,0
mov edi,offset reversebuffer
mov al,10
mov [edi],al
add edi,1
add temp2,1

mov eax,msecondspassed
num4:
mov edx,0
div temp1
push eax
mov eax,edx
add eax,48
mov [edi],al
add edi,1
add temp2,1
pop eax
cmp eax,0
ja num4

mov al,10
mov [edi],al
add edi,1
add temp2,1

mov eax,stepsToFinish
num3:
mov edx,0
div temp1
push eax
mov eax,edx
add eax,48
mov [edi],al
add edi,1
add temp2,1
pop eax
cmp eax,0
ja num3

mov al,10
mov [edi],al
add edi,1
add temp2,1

mov eax,wrongCount
num2:
mov edx,0
div temp1
push eax
mov eax,edx
add eax,48
mov [edi],al
add edi,1
add temp2,1
pop eax
cmp eax,0
ja num2

mov al,10
mov [edi],al
add edi,1
add temp2,1

mov eax,rightCount
num1:

mov edx,0
div temp1
push eax
mov eax,edx
add eax,48
mov [edi],al
add edi,1
add temp2,1
pop eax
cmp eax,0
ja num1

mov esi,offset reversebuffer
add esi,temp2
sub esi,1
mov edi,offset buffer
mov ecx,temp2

L1:
mov al,[esi]
mov [edi],al

add edi,1
sub esi,1
loop L1

mov edx,offset reportl
call createOutputFile
mov fileHandle,eax

mov edx,offset buffer
mov ecx,temp2
call writetofile
mov eax,fileHandle
call CloseFile


ret
savereport ENDP

;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;readboards;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
readBoards PROC arrboard:ptr dword, arrIndices:ptr dword, arrSolution:ptr dword,num1:dword

mov temp1,0
mov eax,num1
mov n1,eax
call RandomBoard
mov n2,eax


cmp n1,0
je loadBoard
cmp n1,1
je easy
cmp n1,2
je med
cmp n1,3
je hard

loadBoard:
 mov boardpath,offset loadb
 mov solpath,offset loads
 push arrIndices
 call loadIndeces
 pop arrIndices
 jmp determinePath

easy:
cmp n2,1
je e1
cmp n2,2
je e2
cmp n2,3
je e3
e1:
 mov boardpath,offset easy1b
 mov solpath,offset easy1s
 jmp determinePath
e2:
 mov boardpath,offset easy2b
 mov solpath,offset easy2s
 jmp determinePath
e3:
 mov boardpath,offset easy3b
 mov solpath,offset easy3s
 jmp determinePath


med:
cmp n2,1
je m1
cmp n2,2
je m2
cmp n2,3
je m3

m1:
mov boardpath,offset med1b
mov solpath,offset med1s
jmp determinePath
m2:
mov boardpath,offset med2b
mov solpath,offset med2s
jmp determinePath
m3:
mov boardpath,offset med3b
mov solpath,offset med3s
jmp determinePath


hard:
cmp n2,1
je h1
cmp n2,2
je h2
cmp n2,3
je h3
h1:
mov boardpath,offset hard1b 
mov solpath,offset hard1s 
jmp determinePath
h2:
mov boardpath,offset hard2b 
mov solpath,offset hard2s 
jmp determinePath
h3:
mov boardpath,offset hard3b 
mov solpath,offset hard3s 

determinePath:

mov edx, boardpath
call readingProcess
mov edi,arrboard
push arrindices
call copyToArray
pop arrIndices

add temp1,1

mov edx, solpath
call readingProcess
mov edi,arrSolution
push arrindices
call copyToArray
pop arrIndices

ret
readBoards ENDP
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;;;;;;;;;;;;;;;;;;;;;;;;;readingProcess;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
readingProcess Proc
call OpenInputFile
mov fileHandle,eax

;cmp eax,INVALID_HANDLE_VALUE
;jne file_ok
;mWrite <"Cannot open file",0dh,0ah>
;jmp quit 

;file_ok:
mov edx,OFFSET buffer
mov ecx,BUFFER_SIZE
call ReadFromFile
;jnc check_buffer_size 
;mWrite "Error reading file. "
;call WriteWindowsMsg
;jmp close_file

;check_buffer_size: 
;cmp eax,BUFFER_SIZE
;jb buf_size_ok 
;mWrite <"Error: Buffer too small for the file",0dh,0ah>
;jmp quit 

;buf_size_ok:

;close_file:
mov eax,fileHandle
call CloseFile
;quit:

ret
readingProcess ENDP
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;copyToArray;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
copyToArray PROC 

mov esi, offset buffer
mov ecx,lengthof buffer
mov ebx,[esp+4]

L1:
mov al,byte ptr [esi]
cmp al,'0'
jb nth
cmp al,'9'
ja nth
sub al,48
movzx eax,al
mov [edi], eax
add edi,4

cmp n1,0
je nth
cmp temp1,0
jne nth
cmp eax,0
je noChange
mov eax,1
dec stepsToFinish
noChange:
mov [ebx],eax
add ebx,4
nth:
add esi,1
loop l1

ret
copyToArray ENDP
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;;;;;;;;;;;;;;;;;;;;loadIndeces;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
loadIndeces PROC

mov edx, offset loadi
call readingprocess

mov edi,[esp+4]
call copyToArray

ret
loadIndeces ENDP
;;;;;;;;;;;;;;;;;;;;;;;;;;saveBoard;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
saveBoard PROC arrboard:ptr dword, arrSolution:ptr dword, arrIndices :ptr dword

mov esi, arrboard
call moveArrToBuffer
mov edx, offset loadb
call writingProcess

mov esi, arrSolution
call moveArrToBuffer
mov edx, offset loads
call writingProcess

mov esi, arrIndices
call moveArrToBuffer
mov edx, offset loadi
call writingProcess

ret
saveBoard ENDP
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
moveArrToBuffer PROC

mov edi, offset buffer

mov ecx, 81
mov ebx,1
l1:
mov eax,[esi]
add eax,48
mov [edi],al

cmp ebx,9
je endl
cmp ebx,18
je endl
cmp ebx,27
je endl
cmp ebx,36
je endl
cmp ebx,45
je endl
cmp ebx,54
je endl
cmp ebx,63
je endl
cmp ebx,72
jne endI

endl:
add edi,1
mov al,10
mov [edi],al
jmp endI

endI:
add esi,4
add edi,1
add ebx,1
loop l1

ret
moveArrToBuffer ENDP 
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
writingProcess PROC

call createOutputFile

;cmp eax, INVALID_HANDLE_VALUE 
;je errormsg
mov edx,offset buffer
mov ecx,89
call writetofile
call closeFile
;jmp endfn

;errormsg:
;mWrite <"Cannot open file",0dh,0ah>

;endfn:
ret
writingProcess ENDP
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;RandomFunction;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
RandomBoard proc
call randomize
mov eax,3
call randomrange
add eax,1
ret
RandomBoard endp
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;getrightCount;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
getrightCount proc
mov eax,rightCount
ret
getrightCount endp
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;getwrongCount;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
getwrongCount proc
mov eax,wrongCount
ret
getwrongCount endp
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;getstepsToFinish;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
getstepsToFinish proc
mov eax,stepsToFinish
ret
getstepsToFinish endp
;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;






; DllMain is required for any DLL
DllMain PROC hInstance:DWORD, fdwReason:DWORD, lpReserved:DWORD
mov eax, 1 ; Return true to caller.
ret
DllMain ENDP
END DllMain