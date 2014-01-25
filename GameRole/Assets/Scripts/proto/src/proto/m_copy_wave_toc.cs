namespace proto {
	public class m_copy_wave_toc : Message
	{
		public int wave = 0;
		public m_copy_wave_toc() {
		}
		public override string getMethodName() {
			return "copy_wave";
		}
		public override string getClassName() {
			return "m_copy_wave_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"wave", "int", "null"}};
		}
	}
}
