namespace proto {
	public class m_pet_dead_toc : Message
	{
		public double pet_id = 0;
		public int life = 0;
		public m_pet_dead_toc() {
		}
		public override string getMethodName() {
			return "pet_dead";
		}
		public override string getClassName() {
			return "m_pet_dead_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"pet_id", "double", "null"},new string[] {"life", "int", "null"}};
		}
	}
}
