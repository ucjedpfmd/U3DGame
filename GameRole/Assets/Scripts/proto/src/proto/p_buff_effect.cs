namespace proto {
	public class p_buff_effect : Message
	{
		public int effect_type = 0;
		public int effect_value = 0;
		public int buff_type = 0;
		public p_buff_effect() {
		}
		public override string getClassName() {
			return "p_buff_effect";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"effect_type", "int", "null"},new string[] {"effect_value", "int", "null"},new string[] {"buff_type", "int", "null"}};
		}
	}
}
