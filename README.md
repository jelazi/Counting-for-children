# Counting for Children

An arithmetic drill for small children that talks to them in a familiar voice. Windows
application in C#, 2017.

## The idea

Practising addition and subtraction is dull, and a child who cannot yet read comfortably gets
nothing from a screen full of text. This one speaks: the exercise, the encouragement while the
child thinks, the reaction to an answer and the goodbye at the end are all recorded audio, and
the recordings are of people the child knows.

That is the whole trick, and it is why the app is not generic. Every phrase was recorded in three
different voices, and the file names carry the voice: the app picks one at random, so the same
praise comes back in a different voice each time.

## What it does

- **Addition, subtraction, or both mixed**, chosen at the start
- **A separate number range for each of the two operands**, set in a dialog, so the difficulty
  can be raised one side at a time
- **Spoken prompts and reactions** drawn at random from a pool for each situation, so it does not
  repeat the same phrase every time — there are separate pools for the start, the choice of
  operation, waiting, a right answer, a wrong answer and the ending
- **Visual feedback** with a smiling, thinking, or sad face

## Implementation notes

| Piece | File |
|---|---|
| Main form, exercise generation, scoring | `pocitani.cs`, `formPocitani.cs` |
| Number range dialog (`rozmezi` = range) | `rozmezi.cs` |
| Random sound selection and playback | `Sound.cs` (`System.Media.SoundPlayer`) |
| Entry point | `Program.cs` |

Windows Forms on .NET Framework. Sound files live in `sounds/` next to the executable, one
directory per situation; adding a new recording means dropping a `.wav` into the right directory.
Interface and audio in Czech.

## Building

Open `pocitani.csproj` in Visual Studio and build. No external dependencies.

## Status

Archived — my first finished application, kept as it was.
