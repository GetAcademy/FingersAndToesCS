namespace FingersAndToesCS
{
    class FingerAndToeCollection
    {
        public string[] Names = { "lille", "ring", "midt", "peke", "tommel", "storetå" };
        public FingerOrToe[] FingersAndToes = new FingerOrToe[] {
            new FingerOrToe { IsLeftSide = true, Index = 0, Type = 0 },
            new FingerOrToe { IsLeftSide = true, Index = 1, Type = 0 },
            new FingerOrToe { IsLeftSide = true, Index = 2, Type = 0 },
            new FingerOrToe { IsLeftSide = true, Index = 3, Type = 0 },
            new FingerOrToe { IsLeftSide = true, Index = 4, Type = 0 },
            new FingerOrToe { IsLeftSide = false, Index = 0, Type = 0 },
            new FingerOrToe { IsLeftSide = false, Index = 1, Type = 0 },
            new FingerOrToe { IsLeftSide = false, Index = 2, Type = 0 },
            new FingerOrToe { IsLeftSide = false, Index = 3, Type = 0 },
            new FingerOrToe { IsLeftSide = false, Index = 4, Type = 0 },
            new FingerOrToe { IsLeftSide = true, Index = 0, Type = 1 },
            new FingerOrToe { IsLeftSide = true, Index = 1, Type = 1 },
            new FingerOrToe { IsLeftSide = true, Index = 2, Type = 1 },
            new FingerOrToe { IsLeftSide = true, Index = 3, Type = 1 },
            new FingerOrToe { IsLeftSide = true, Index = 4, Type = 1 },
            new FingerOrToe { IsLeftSide = false, Index = 0, Type = 1 },
            new FingerOrToe { IsLeftSide = false, Index = 1, Type = 1 },
            new FingerOrToe { IsLeftSide = false, Index = 2, Type = 1 },
            new FingerOrToe { IsLeftSide = false, Index = 3, Type = 1 },
            new FingerOrToe { IsLeftSide = false, Index = 4, Type = 1 },
        };

        public void ToggleIsFingerOrToeDone( int index)
        {
            var fingerOrToe = FingersAndToes[index];
            fingerOrToe.IsDone = !fingerOrToe.IsDone;
        }
    }
}
