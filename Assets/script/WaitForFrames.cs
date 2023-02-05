using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForFrames : CustomYieldInstruction
{
    private int frames;

    public WaitForFrames(int frames)
	{
        this.frames = frames;
	}

	public override bool keepWaiting => frames-- > 0;
}
