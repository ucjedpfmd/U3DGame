namespace proto {
	public class m_pet_quit_toc : Message
	{
		public double pet_id = 0;
		public m_pet_quit_toc() {
		}
		public override string getMethodName() {
			return "pet_quit";
		}
		public override string getClassName() {
			return "m_pet_quit_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_id", "double", "null"}};
		}
	}
}
