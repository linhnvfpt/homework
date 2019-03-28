import pytest
import exer14

def test_inc():
    assert exer14.inc(4) == 6

def test_removeDuplicateUseList():
    assert exer14.removeDuplicateUseList([1,1,2,3,4,4,4,6,7,7,7,8,9,2,2]) == [1,2,3,4,6,7,8,9]