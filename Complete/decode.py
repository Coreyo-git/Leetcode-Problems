# Function to decode the message
def decode(message_file):
    # Step 1: Read and process the message file to populate decode_dict
    decode_dict = {}
    with open(message_file, 'r') as f:
        # Split the line into sections based on space delimiter
        for line in f:
            # Extract the number and the word from the sections
            num, word = line.strip().split(' ')
            # Convert the number to an integer
            num = int(num)
            # Store the number-word pair in the decode_dict
            decode_dict[num] = word
            
    # Step 2: Sort the decode_dict by keys to get the numbers in ascending order
    sorted_dict = dict(sorted(decode_dict.items()))
    
    # Step 3: Get the triangular numbers that exist in the sorted_dict keys
    triangular_numbers = get_triangular_numbers(sorted_dict.keys())
    
    # Step 4: Decode the message using the sorted_dict and the triangular numbers
    message_decoded = [sorted_dict[num] for num in triangular_numbers]
    
    # Step 5: Return the decoded message as a space-separated string
    return ' '.join(message_decoded)

# Function to get triangular numbers from the list of keys
def get_triangular_numbers(keys):
    max_key = max(keys)
    return [(n * (n + 1)) // 2 for n in range(1, max_key + 1) if n * (n + 1) // 2 in keys]

# Call the decode function with the input file path and print the result
decoded_message = decode('inputs.txt')
print(decoded_message)

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

# The numbers at the end of each line (1, 3 and 6) correspond to the words that are part of the message. You should ignore all the other words. So for the example input file above, the message words are:
# 1: I
# 3: love
# 6: computers

# and your function should return the string "I love computers."
