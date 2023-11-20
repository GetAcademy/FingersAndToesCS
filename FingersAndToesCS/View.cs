namespace FingersAndToesCS
{
    class View
    {
        public static void Update(FingerAndToeCollection fingerAndToes)
        {
            Console.WriteLine(CreateHtmlFromFingersAndToes(fingerAndToes));
            Console.WriteLine($"[ ] Venstre hånd {GetCountText(true, 0, fingerAndToes)}");
            Console.WriteLine($"[ ] Høyre hånd {GetCountText(false, 0,fingerAndToes)}");
            Console.WriteLine($"[ ] Venstre fot {GetCountText(true, 1,fingerAndToes)}");
            Console.WriteLine($"[ ] Høyre fot {GetCountText(false, 1,fingerAndToes)}");
            Console.WriteLine($"[ ] Høyre side {GetCountText(false, null,fingerAndToes)}");
            Console.WriteLine($"[ ] Venstre side {GetCountText(true, null,fingerAndToes)}");
            Console.WriteLine($"[ ] Begge hender {GetCountText(null, 0,fingerAndToes)}");
            Console.WriteLine($"[ ] Begge føtter {GetCountText(null, 1,fingerAndToes)}");
            Console.WriteLine($"[ ] Alt ferdig {GetCountText(null, null,fingerAndToes)}\n");
        }
        static string GetCountText(bool? isLeftSide, int? type, FingerAndToeCollection model)
        {
            (int total, int done) = GetCount(isLeftSide, type, model);
            return $"({done} av {total})";
        }

        static (int total, int done) GetCount(bool? isLeftSide, int? type, FingerAndToeCollection model)
        {
            int total = 0;
            int done = 0;
            foreach (FingerOrToe fingerOrToe in model.FingersAndToes)
            {
                if (isLeftSide != null && fingerOrToe.IsLeftSide != isLeftSide) continue;
                if (type != null && fingerOrToe.Type != type) continue;
                total++;
                if (fingerOrToe.IsDone) done++;
            }
            return (total, done);
        }
        public static string CreateHtmlFromFingersAndToes(FingerAndToeCollection model)
        {
            var text = "";
            foreach (var fingerOrToe in model.FingersAndToes)
            {
                var check = fingerOrToe.IsDone ? "X" : " ";
                text += $"[{check}] {GetDescription(fingerOrToe, model)}\n";
            }
            return text;
        }

        public static string GetDescription(FingerOrToe fingerOrToe, FingerAndToeCollection model)
        {
            string side = fingerOrToe.IsLeftSide ? "venstre" : "høyre";
            string detail = model.Names[fingerOrToe.Index];

            if (detail is string)
            {
                return $"{side} {detail} {GetEntity(fingerOrToe.Type)}";
            }
            // anta at detail er tekst
            return $"{side} {detail[fingerOrToe.Type]}";
        }

        private static string GetEntity(int type)
        {
            return type == 0 ? "finger" : "tå";
        }
    }
}
