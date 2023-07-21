# Global variables
# Dictionary to store the decoded key-value pairs (number-word mapping)
decode_dict = {}
triangular_numbers = []  # List to store the triangular numbers used for decoding

# Function to decode the message
# Pass in a file location as the message_file parameter

def decode(message_file):
    # Step 1: Read and process the message file to populate decode_dict
    # Open the message_file in read mode
    with open(message_file, 'r') as f:
        for line in f:
            # Split the line into sections based on space delimiter
            sections = line.strip().split(' ')
            # Extract the number and the word from the sections
            num, word = sections
            # Convert the number to an integer
            num = int(num)
            # Store the number-word pair in the decode_dict
            decode_dict[num] = word
            
 	# Step 2: Sort the decode_dict by keys to get the numbers in ascending order
    sorted_dict = dict(sorted(decode_dict.items()))
    
    # Step 3: Get the triangular numbers up to the number of items in sorted_dict
    get_triangular_numbers(len(sorted_dict))
    
    # Step 4: Decode the message using the sorted_dict and the triangular numbers
    message_decoded = ""
    for num in triangular_numbers:
        value = sorted_dict[num]
        message_decoded += f"{value} "

    # Step 5: Return the decoded message
    return message_decoded

# Function to get triangular numbers up to the number max
def get_triangular_numbers(max):
    n = 1
    # while is less than or equal to the max number:
    while (n * (n + 1)) // 2 <= max:
        # Append the triangular number
        triangular_numbers.append((n * (n + 1)) // 2) 
        n += 1 # Increment by 1
    return

# Call the decode function with the input file path
decode('inputs.txt')


# Prompt
# I need a function called decode(message_file) that can read in an encoded message from a .txt file and return the decoded version as a string.
# Here's an example of what the message_file .txt file will look like:

# 3 love
# 6 computers
# 2 dogs
# 4 cats
# 1 I
# 5 you

# As you can see, each word is associated with a number. Imagine you ordered all those numbers from smallest to biggest and arranged them into a pyramid. Each line of the pyramid includes one more number than the line before it:
# 1
# 2 3
# 4 5 6
# 7 8 9 10
# 11 12 13 14
# 15 16 17 18 19

# The numbers at the end of each line (1, 3 and 6) correspond to the words that are part of the message. You should ignore all the other words. So for the example input file above, the message words are:
# 1: I
# 3: love
# 6: computers

# and your function should return the string "I love computers."
