namespace proto {
	public class m_move_sync_toc : Message
	{
		public double roleid = 0;
		public int pos = 0;
		public m_move_sync_toc() {
		}
		public override string getMethodName() {
			return "move_sync";
		}
		public override string getClassName() {
			return "m_move_sync_toc";
		}
		public override string[][] getAttributes() {
			return new string[][] {new string[] {"roleid", "double", "null"},new string[] {"pos", "int", "null"}};
		}
	}
}
