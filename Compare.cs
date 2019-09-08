namespace CompareString {
    public static class Compare {

        public static bool VerifySimilarity (char[] text, char[] text1) {
            if (!VerifyCount (text, text1)) {
                return false;
            }
            if (text.Length == text1.Length) {
                return VerifyReplace (text, text1);
            }
            return VerifyInsertionDelete (text, text1);
        }
        private static bool VerifyCount (char[] arrayText, char[] arrayText1) {
            if (arrayText.Length == arrayText1.Length ||
                arrayText.Length == arrayText1.Length + 1 ||
                arrayText.Length == arrayText1.Length - 1) {
                return true;
            }
            return false;
        }

        private static bool VerifyReplace (char[] text, char[] text1) {
            int count = 0;

            for (int i = 0; i < text.Length; i++) {
                if (text[i] == text1[i]) {
                    count++;
                }
            }
            if (count == text.Length - 1) {
                return true;
            }
            return false;
        }

        private static bool VerifyInsertionDelete (char[] text, char[] text1) {
            int count = 0;
            char[] smalArray = GetSmallestArray (text, text1);

            for (int i = 0; i < smalArray.Length; i++) {
                if (text[i] == text1[i]) {
                    count++;
                }
            }
            if (count == smalArray.Length) {
                return true;
            }
            return false;
        }
        private static char[] GetSmallestArray (char[] arrayText, char[] arrayText1) {
            if (arrayText.Length < arrayText1.Length) {
                return arrayText;
            }
            return arrayText1;
        }
    }
}