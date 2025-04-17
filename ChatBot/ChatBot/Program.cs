using System;
using System.Media;
using System.IO;
using ChatBot;

namespace CybersecurityBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- 🔊 1. Voice Greeting ---
            try
            {
                Utils utils = new Utils();
                AudioPlayer audioPlayer = new AudioPlayer();
                audioPlayer.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error playing voice greeting: {ex.Message}");
            }

            // --- 🖼️ 2. Image Display (ASCII Art from User Input) ---
            string logo = @"
 ____     _                    ____                    _ _    
/ ___|   _| |__  ___ _ __/ ___| ___  ___ _  _ _ __(_) |_ _  _
| |     | | '_ \/ _ \ '__\___ \/ _ \/ __| | | | '__| | __| | |
| |___  |_| |_) |  __/ |  ___) |  __/ (__| |_| | |  | | |_| |_|
\____\__, |_.__/ \___|_| |____/ \___|\___|\__,_|_|  |_|\__|\__, |
 ____|___/      _    ____     _                                |___/
/ ___| |__  __ _| |_| __ )  ___ | |_
| |    | '_ \/ _` | __| _ \ / _ \| __|
| |___ | | | | (_| | |_| |_) | (_) | |_
\____|_| |_|\__,_|\__|____/ \___/ \__|
";
            // Split into lines
            string[] lines = logo.Split('\n');

            // Display the logo at the top-left corner
            foreach (string line in lines)
            {
                Console.WriteLine(line); // No padding, so it starts from the left
            }
            Console.WriteLine(); // Add an empty line for spacing

            // Image instance to display an image

            ImageDisplay display = new ImageDisplay();
            display.Show();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("+-----------------------------+");
            Console.WriteLine("|     Let's stay cyber safe! |");
            Console.WriteLine("+-----------------------------+");
            Console.WriteLine();

            // --- 🧑‍💻 3. Text-Based Greeting and User Interaction ---
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Bot: What is your name? ");
            Console.WriteLine();
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("You: ");
            string name = Console.ReadLine();
            Console.ResetColor();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nWelcome, Guest! Let's stay cyber safe!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nWelcome, {name}! Great to have you here.");
                Console.ResetColor();
            }



            // --- 💬 4. Basic Interaction System ---
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("You: ");
                string question = Console.ReadLine()?.ToLower();
                Console.ResetColor();

                if (string.IsNullOrWhiteSpace(question))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Bot: Please enter a question.");
                    Console.ResetColor();
                    continue;
                }

                if (question.Contains("exit") || question.Contains("thank you")) // Added "thank you" here
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Bot: You're welcome! Stay safe online!"); // Modified the exit message slightly
                    Console.ResetColor();
                    break;
                }
                else if (question.Contains("purpose"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Bot: My purpose is to educate you on the fundamental principles of cybersecurity and online safety. I aim to provide clear and concise information to help you understand common threats and learn practical steps to protect yourself in the digital world. Think of me as your friendly guide to staying safe online.");
                    Console.ResetColor();
                }
                else if (question.Contains("passwords") && question.Contains("strong") || question.Contains("password"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Bot: Creating a strong password is crucial for protecting your online accounts. A strong password should ideally include a combination of:");
                    Console.WriteLine("- Uppercase letters (A-Z)");
                    Console.WriteLine("- Lowercase letters (a-z)");
                    Console.WriteLine("- Numbers (0-9)");
                    Console.WriteLine("- Special symbols (!@#$%^&* etc.)");
                    Console.WriteLine("Aim for a password that is at least 12-15 characters long and avoid using personal information that is easy to guess, such as your name, date of birth, or common words. Consider using a password manager to generate and securely store complex passwords.");
                    Console.ResetColor();
                }
                else if (question.Contains("phishing"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Bot: Phishing is a deceptive tactic used by cybercriminals to trick you into revealing sensitive information. This is often done through emails, text messages, or even phone calls that impersonate legitimate organizations like banks, social media platforms, or government agencies.");
                    Console.WriteLine("The goal of phishing attacks is usually to steal your login credentials (usernames and passwords), credit card details, personal identification numbers, or other valuable data. Be cautious of unsolicited communications asking for personal information or urging you to click on suspicious links or download attachments.");
                }
                else if (question.Contains("malware"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Bot: Malware is a broad term for malicious software designed to harm or exploit computer systems, networks, or users. There are many types of malware, including:");
                    Console.WriteLine("- **Viruses:** These attach themselves to legitimate files and spread when those files are executed.");
                    Console.WriteLine("- **Worms:** These can self-replicate and spread across networks without needing a host file.");
                    Console.WriteLine("- **Trojans:** These disguise themselves as legitimate software but perform malicious actions in the background, often creating backdoors for attackers.");
                    Console.WriteLine("- **Ransomware:** This type of malware encrypts your files and demands a ransom payment for their decryption.");
                    Console.WriteLine("- **Spyware:** This secretly monitors your activity, collects sensitive information like keystrokes and browsing data, and sends it to attackers.");
                    Console.WriteLine("Protecting against malware involves using reputable antivirus software, keeping your software updated, being cautious about downloads and links, and practicing safe browsing habits.");
                    Console.ResetColor();
                }
                else if (question.Contains("cyber attack") || question.Contains("cyberattack"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Bot: A cyberattack is a deliberate attempt to gain unauthorized access to a computer system, network, or digital device with the intent to disrupt operations, steal data, or cause other malicious harm. Cyberattacks can take many forms, including:");
                    Console.WriteLine("- **Phishing:** (As explained earlier)");
                    Console.WriteLine("- **Malware Attacks:** (As explained earlier)");
                    Console.WriteLine("- **Denial of Service (DoS) and Distributed Denial of Service (DDoS) Attacks:** These aim to overwhelm a target system with traffic, making it unavailable to legitimate users.");
                    Console.WriteLine("- **SQL Injection:** This targets databases by inserting malicious SQL code to gain unauthorized access or manipulate data.");
                    Console.WriteLine("- **Man-in-the-Middle (MitM) Attacks:** Attackers intercept communication between two parties to eavesdrop or manipulate the data being exchanged.");
                    Console.WriteLine("- **Brute-Force Attacks:** These involve trying many different passwords or encryption keys until the correct one is found.");
                    Console.WriteLine("Staying informed about these threats and implementing security best practices is essential for preventing cyberattacks.");
                    Console.ResetColor();
                }
                else if (question.Contains("how are you"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Bot: As a digital entity, I don't experience emotions in the same way humans do. However, I am functioning optimally and ready to assist you with your cybersecurity inquiries. My systems are running smoothly, and I'm here to provide you with the information you need to stay safe online.");
                    Console.ResetColor();
                }
                else if (question.Contains("what can i ask you"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Ask me anything regarding Cybersecurity!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Bot: This concept is not part of the Cybersecurity Context!!!");
                    Console.WriteLine(" Bot: While I'm still learning, try asking about basic cybersecurity concepts like passwords, phishing, malware, or cyberattacks.");
                    Console.ResetColor();
                }
                Console.WriteLine(); // Add an empty line for better readability between questions and answers
            }

            // --- 🖌️ 6. Enhanced Console UI with Visual Elements ---
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nStay vigilant in the digital realm!");
            Console.ResetColor();
        }
    }
}