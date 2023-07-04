public class Door { //unfinished...
    public DoorState door_state {get; private set;} //i can probably change them mena (f the set), we'll see later
    private string passcode;

    public Door(String p) {
        door_state = DoorState.Closed;
        if(passcode == null) passcode = string.Empty;
        passcode = p;
    }

    public void changeState(DoorState ds) {
        if(door_state != DoorState.Locked) {
            if(ds == DoorState.Closed) { //user wants to close, else wants to close

                if(door_state == DoorState.Closed) { //door was closed, else it was open
                Console.WriteLine("Door is already closed.");
                } else {
                    Console.WriteLine("Door has been closed.");
                    door_state = DoorState.Closed;
                }
            } else {
                if(door_state == DoorState.Open) { 
                    Console.WriteLine("Door is already open.");
                } else {
                    Console.WriteLine("Door has been opened.");
                    door_state = DoorState.Open;
                }
            }
        } else {

        }      
    }
}

public enum DoorState {Closed, Open, Locked}

/*basically :
    i have a door Object.
    it can either be open, closed or locked. (ida its open or closed tsema rahi unlocked)
    i can   open it (if closed), 
            close it (if open),
            unlock it (if locked),
            lock it (if closed)
*/

