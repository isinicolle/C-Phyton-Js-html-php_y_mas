import tkinter as tk
from tkinter import filedialog
import os.path


def choose_file():
    root = tk.Tk()
    root.withdraw()

    print("Select .txt file...")
    file_path = filedialog.askopenfilename()
    return open(file_path, 'r')


def save_file(file_name, file_text):
    print("Choose folder to save file...")
    save_path = filedialog.askdirectory()
    new_file_path = os.path.join(save_path, file_name)
    new_file = open(new_file_path, 'w')
    new_file.write(file_text)
    new_file.close()


def encrypt_method_1():
    letters = ('A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
               'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z')
    file = choose_file()

    encrypted_text = []

    for line in file:
        for word in line.split():
            for idx, letter in enumerate(word):
                upperFlag = False
                if not letter.isupper():
                    upperFlag = True
                    letter = letter.upper()

                next_idx = letters.index(letter) + idx + 1
                if next_idx >= len(letters):
                    next_idx = 0

                enc = letters[next_idx]
                if upperFlag:
                    enc = enc.lower()
                encrypted_text.append(enc)

            encrypted_text.append(' ')

    encrypted_text = ''.join(encrypted_text)

    new_file_name = os.path.basename(file.name).split('.')[
        0] + '_encrypted_1.txt'

    save_file(new_file_name, encrypted_text)
    file.close()


def decrypt_method_1():
    letters = ('A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
               'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z')
    file = choose_file()

    decrypted_text = []

    for line in file:
        for word in line.split():
            for idx, letter in enumerate(word):
                upperFlag = False
                if not letter.isupper():
                    upperFlag = True
                    letter = letter.upper()

                next_idx = letters.index(letter) - idx - 1
                if next_idx < 0:
                    next_idx = len(letters) - 1

                enc = letters[next_idx]
                if upperFlag:
                    enc = enc.lower()
                decrypted_text.append(enc)

            decrypted_text.append(' ')

    decrypted_text = ''.join(decrypted_text)

    new_file_name = os.path.basename(file.name).split('.')[
        0] + '_decrypted_1.txt'

    save_file(new_file_name, decrypted_text)
    file.close()


def encrypt_method_2():
    first_letters = ('A', 'B', 'C', 'D', 'E', 'F', 'G',
                     'H', 'I', 'J', 'K', 'L', 'M', 'N')
    second_letters = ['Ñ', 'O', 'P', 'Q', 'R', 'S',
                      'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '-']
    file = choose_file()

    encrypted_text = []

    for line in file:
        for word in line.split():
            for i in word:
                second_letters.insert(0, second_letters.pop())

            for letter in word:
                upperFlag = False
                if not letter.isupper():
                    upperFlag = True
                    letter = letter.upper()
                enc = ''

                if letter in first_letters:
                    idx = first_letters.index(letter)
                    enc = second_letters[idx]
                else:
                    idx = second_letters.index(letter)
                    enc = first_letters[idx]

                if upperFlag:
                    enc = enc.lower()
                encrypted_text.append(enc)

            encrypted_text.append(' ')

    encrypted_text = ''.join(encrypted_text)

    new_file_name = os.path.basename(file.name).split('.')[
        0] + '_encrypted_2.txt'

    save_file(new_file_name, encrypted_text)
    file.close()


def decrypt_method_2():
    first_letters = ('A', 'B', 'C', 'D', 'E', 'F', 'G',
                     'H', 'I', 'J', 'K', 'L', 'M', 'N')
    second_letters = ['Ñ', 'O', 'P', 'Q', 'R', 'S',
                      'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '-']
    file = choose_file()

    decrypted_text = []
    initial_gap = 0
    text = ''

    for line in file:
        for word in line.split():
            for letter in word:
                text += letter
                initial_gap = initial_gap + 1
            text += ' '

    for i in range(initial_gap):
        second_letters.insert(0, second_letters.pop())

    for word in text.split()[::-1]:

        for letter in word:
            upperFlag = False
            if not letter.isupper():
                upperFlag = True
                letter = letter.upper()
            enc = ''

            if letter in first_letters:
                idx = first_letters.index(letter)
                enc = second_letters[idx]
            else:
                idx = second_letters.index(letter)
                enc = first_letters[idx]

            if upperFlag:
                enc = enc.lower()
            decrypted_text.append(enc)

        decrypted_text.append(' ')

        for i in word:
            second_letters.insert(
                len(second_letters) - 1, second_letters.pop(0))

    decrypted_text = ''.join(decrypted_text)
    decrypted_text = decrypted_text.split()[::-1]
    decrypted_text = ' '.join(decrypted_text)

    new_file_name = os.path.basename(file.name).split('.')[
        0] + '_decrypted_2.txt'

    save_file(new_file_name, decrypted_text)
    file.close()


def encrypt_method_3():
    wordsMatrix = [
        ['m', 'u', 'r', 'c', 'i', 'e', 'l', 'a', 'g', 'o'],
        ['h', 'i', 'p', 'o', 't', 'e', 'n', 'u', 's', 'a'],
        ['e', 's', 'c', 'u', 'p', 'i', 't', 'a', 'j', 'o'],
        ['s', 'u', 'd', 'o', 'r', 'i', 'e', 'n', 't', 'a'],
        ['a', 'l', 'f', 'e', 'ñ', 'i', 'q', 'u', 'e', 's'],
        ['b', 'o', 'l', 'i', 'v', 'i', 'a', 'n', 'o', 's'],
        ['d', 'e', 'c', 'i', 'n', 'e', 'w', 't', 'o', 'n'],
        ['e', 'x', 'h', 'o', 'r', 't', 'a', 'd', 'o', 'r'],
        ['i', 'n', 'j', 'e', 'r', 't', 'a', 'd', 'o', 'r'],
        ['y', 'o', 'c', 't', 'o', 'g', 'r', 'a', 'm', 'o']
    ]
    file = choose_file()

    encrypted_text = []

    for line in file:
        for word in line.split():
            counter = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0]
            read_word = ''
            for letter in word:
                read_word += letter
                for i, w in enumerate(wordsMatrix):
                    if letter in w:
                        counter[i] = counter[i] + 1

            max_val = max(counter)
            idx_max = counter.index(max_val)

            encrypted_text.append(str(idx_max))
            for letter in read_word:
                lowerFlag = False
                if not letter.islower():
                    lowerFlag = True
                    letter = letter.lower()
                idx = letter

                if letter in wordsMatrix[idx_max]:
                    idx = str(wordsMatrix[idx_max].index(letter))

                if lowerFlag:
                    idx = idx.lower()
                encrypted_text.append(idx)
            encrypted_text.append(' ')

    encrypted_text = ''.join(encrypted_text)
    new_file_name = os.path.basename(file.name).split('.')[
        0] + '_encrypted_3.txt'

    save_file(new_file_name, encrypted_text)
    file.close()


def decrypt_method_3():
    wordsMatrix = [
        ['m', 'u', 'r', 'c', 'i', 'e', 'l', 'a', 'g', 'o'],
        ['h', 'i', 'p', 'o', 't', 'e', 'n', 'u', 's', 'a'],
        ['e', 's', 'c', 'u', 'p', 'i', 't', 'a', 'j', 'o'],
        ['s', 'u', 'd', 'o', 'r', 'i', 'e', 'n', 't', 'a'],
        ['a', 'l', 'f', 'e', 'ñ', 'i', 'q', 'u', 'e', 's'],
        ['b', 'o', 'l', 'i', 'v', 'i', 'a', 'n', 'o', 's'],
        ['d', 'e', 'c', 'i', 'n', 'e', 'w', 't', 'o', 'n'],
        ['e', 'x', 'h', 'o', 'r', 't', 'a', 'd', 'o', 'r'],
        ['i', 'n', 'j', 'e', 'r', 't', 'a', 'd', 'o', 'r'],
        ['y', 'o', 'c', 't', 'o', 'g', 'r', 'a', 'm', 'o']
    ]
    file = choose_file()

    decrypted_text = []

    for line in file:
        for word in line.split():
            idx = int(word[0])

            for letter in word[1:]:
                dec = letter
                if letter.isdigit():
                    dec = wordsMatrix[idx][int(letter)]
                decrypted_text.append(dec)
            decrypted_text.append(' ')
    decrypted_text = ''.join(decrypted_text)

    new_file_name = os.path.basename(file.name).split('.')[
        0] + '_decrypted_3.txt'

    save_file(new_file_name, decrypted_text)
    file.close()


def encrypt_decrypt_method_4():
    file = choose_file()
    encrypted_text = []

    temp_text_arr = []
    for line in file:
        for word in line:
            temp_text_arr.append(word)
    col = 25
    groups = 5
    text = [temp_text_arr[i:i+col] for i in range(0, len(temp_text_arr), col)]

    matrix = []
    for arr in text:
        arr = arr + [' ']*(col - len(arr))
        matrix.append(arr)

    add_rows_qty = 0
    if len(matrix) % 5 > 0:
        add_rows_qty = groups - (len(matrix) % 5)

    for i in range(add_rows_qty):
        matrix.append([' '] * col)

    iterate = int(len(matrix) / 5)
    encrypted_text = []
    for xyz in range(iterate):
        temp_matrix = [[], [], [], [], []]
        temp_matrix_2 = [[], [], [], [], []]
        temp_matrix_3 = []

        for j in range(groups):
            for i in range(groups):
                temp_matrix[i].append(matrix[j][i*5:(i+1)*5])

        for i in range(groups):
            for j in range(groups):
                temp_matrix_2[j].append([row[j] for row in temp_matrix[i]])

        for arr in temp_matrix_2:
            temp_matrix_3.append(sum(arr, []))

        encrypted_text.append(sum(temp_matrix_3, []))

    encrypted_text = sum(encrypted_text, [])
    encrypted_text = ''.join(encrypted_text)

    new_file_name = os.path.basename(file.name).split('.')[
        0] + '_enc_dec_4.txt'

    save_file(new_file_name, encrypted_text)
    file.close()


def main():
    while True:
        print("\nOptions: ")
        print("1) Encrypt file")
        print("2) Decrypt file")
        print("3) Exit")
        answ = input("Choose one number from above options: ")

        opts = ['1', '2', '3']
        while answ not in opts:
            answ = input("Choose one options from above: ")

        try:
            if answ == '1':
                print("\nEncryption options: ")
                print("1) Method #1")
                print("2) Method #2")
                print("3) Method #3")
                print("4) Method #4")
                print("5) Exit")
                answ = input("Choose one number from above options: ")
                opts = ['1', '2', '3', '4', '5']
                while answ not in opts:
                    answ = input("Choose one options from above: ")

                if answ == '1':
                    encrypt_method_1()
                elif answ == '2':
                    encrypt_method_2()
                elif answ == '3':
                    encrypt_method_3()
                elif answ == '4':
                    encrypt_decrypt_method_4()

            elif answ == '2':
                print("\nDecryption options: ")
                print("1) Method #1")
                print("2) Method #2")
                print("3) Method #3")
                print("4) Method #4")
                print("5) Exit")
                answ = input("Choose one number from above options: ")
                opts = ['1', '2', '3', '4', '5']
                while answ not in opts:
                    answ = input("Choose one options from above: ")

                if answ == '1':
                    decrypt_method_1()
                elif answ == '2':
                    decrypt_method_2()
                elif answ == '3':
                    decrypt_method_3()
                elif answ == '4':
                    encrypt_decrypt_method_4()
            else:
                break
        except:
            print("No file selected... try again")


main()
