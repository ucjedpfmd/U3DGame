namespace proto {
	public class m_box_discover_tos : Message
	{
		public bool bind_first = true;
		public int discover_times = 0;
		public m_box_discover_tos() {
		}
		public override string getMethodName() {
			return "box_discover";
		}
		public override string getClassName() {
			return "m_box_discover_tos";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"bind_first", "bool", "null"},new string[] {"discover_times", "int", "null"}};
		}
	}
}
