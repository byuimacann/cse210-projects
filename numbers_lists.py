numbers = []
number = None
sum = 0 
average = 0 

print('Enter a list of numbers, type 0 when finished. ')

while number != 0:
    number = int(input('Enter number: '))
    if number != 0:
        numbers.append(number)
 
for number in numbers:
    sum += number
    
print(f'The sum is: {sum}')

for number in numbers:
    average = sum / len(numbers)
    
print(f'The average is: {average}')
print(f'The largest number is: ', max(numbers))

numbers.sort()

for number in numbers:
    if number > 0:
        print(f'The smallest positive number is: {number} ') 
        break
               
print(f'The sorted list is: ')

for number in numbers:
    print(number)








    

