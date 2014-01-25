namespace proto {
	public class p_effect : Message
	{
		public int effect_id = 0;
		public int effect_type = 0;
		public int calc_type = 0;
		public int absolute_or_rate = 0;
		public int value = 0;
		public int value_out_type = 0;
		public int probability = 10000;
		public p_effect() {
		}
		public override string getClassName() {
			return "p_effect";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"effect_id", "int", "null"},new string[] {"effect_type", "int", "null"},new string[] {"calc_type", "int", "null"},new string[] {"absolute_or_rate", "int", "null"},new string[] {"value", "int", "null"},new string[] {"value_out_type", "int", "null"},new string[] {"probability", "int", "null"}};
		}
	}
}
