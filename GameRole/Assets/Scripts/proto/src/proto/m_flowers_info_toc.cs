namespace proto {
	public class m_flowers_info_toc : Message
	{
		public int charm_score = 0;
		public m_flowers_info_toc() {
		}
		public override string getMethodName() {
			return "flowers_info";
		}
		public override string getClassName() {
			return "m_flowers_info_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"charm_score", "int", "null"}};
		}
	}
}
