# 🤖 Cybersecurity Awareness ChatBot

A C# console-based chatbot that educates users about cybersecurity using interactive text responses, audio greetings, and ASCII image art.

---

## 📂 Project Structure
# Main Program

static void Main(string[] args)
{
    AudioPlayer audioPlayer = new AudioPlayer();
    audioPlayer.Play();

    ImageDisplay display = new ImageDisplay();
    display.Show();

    Console.Write("Bot: What is your name? ");
    string name = Console.ReadLine();
    Console.WriteLine($"Welcome, {name}!");

    // ... main chat logic follows
}
# Audio Class
public void Play()
{
    string filePath = "Audio/Greetings.wav";
    using (SoundPlayer player = new SoundPlayer(filePath))
    {
        player.PlaySync();
    }
}
# Image Display Class
private void ConvertImageToAscii(string imagePath, int width, int height)
{
    Bitmap image = new Bitmap(imagePath);
    image = new Bitmap(image, new Size(width, height));

    string asciiChars = "@%#*+=-:. ";
    for (int y = 0; y < image.Height; y++)
    {
        for (int x = 0; x < image.Width; x++)
        {
            Color pixelColor = image.GetPixel(x, y);
            int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
            int index = gray * (asciiChars.Length - 1) / 255;
            Console.Write(asciiChars[index]);
        }
        Console.WriteLine();
    }
}
# Preview
 ____     _                    ____                    _ _
/ ___|   _| |__  ___ _ __/ ___| ___  ___ _  _ _ __(_) |_ _  _
| |     | | '_ \/ _ \ '__\___ \/ _ \/ __| | | | '__| | __| | |
| |___  |_| |_) |  __/ |  ___) |  __/ (__| |_| | |  | | |_| |_|
\____\__, |_.__/ \___|_| |____/ \___|\___|\__,_|_|  |_|\__|\__, |

## 🛠️ Built With

- C# (.NET Console App)
- System.Media for sound playback
- System.Drawing for image-to-ASCII conversion
- ANSI Escape Codes for styled text in the console

- # Sample Interaction
- Bot: What is your name?
You: Alex

Bot: Welcome, Alex! Great to have you here.

You: What is phishing?
Bot: Phishing is a deceptive tactic used by cybercriminals...

