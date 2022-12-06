.text
main:
	addi $2 $0 5
	syscall
	add $8 $0 $2
	addi $2 $0 5
	syscall
soma:
	add $9 $8 $2
mensagem:
	add $4 $0 83 #S
	addi $2 $0 11
	syscall
	
	add $4 $0 79#O
	addi $2 $0 11
	syscall
	
	add $4 $0 77#M
	addi $2 $0 11
	syscall
	
	add $4 $0 65 #A
	addi $2 $0 11
	syscall
	
	add $4 $0 32 #espaco
	addi $2 $0 11
	syscall
	add $4 $0 61 #=
	addi $2 $0 11
	syscall
	add $4 $0 32#espaco
	addi $2 $0 11
	syscall
print: 
	add $4 $0 $9
	addi $2 $0 1
	syscall
fim:
	addi $2 $0 10
	syscall
