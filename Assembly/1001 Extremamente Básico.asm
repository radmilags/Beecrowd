.text
main:
	addi $2 $0 5
	syscall
	add $8 $0 $2
	addi $2 $0 5
	syscall
	add $9 $8 $2
	add $4 $0 88
	addi $2 $0 11
	syscall
	add $4 $0 32
	addi $2 $0 11
	syscall
	add $4 $0 61
	addi $2 $0 11
	syscall
	add $4 $0 32
	addi $2 $0 11
	syscall
	add $4 $0 $9
	addi $2 $0 1
	syscall
	addi $2 $0 10
	syscall
