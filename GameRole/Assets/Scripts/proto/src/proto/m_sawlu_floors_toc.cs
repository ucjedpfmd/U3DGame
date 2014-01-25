namespace proto {
	public class m_sawlu_floors_toc : Message
	{
		public int floors = 0;
		public int index = 0;
		public m_sawlu_floors_toc() {
		}
		public override string getMethodName() {
			return "sawlu_floors";
		}
		public override string getClassName() {
			return "m_sawlu_floors_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"floors", "int", "null"},new string[] {"index", "int", "null"}};
		}
	}
}
